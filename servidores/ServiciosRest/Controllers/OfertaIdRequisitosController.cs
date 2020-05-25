// Template: Controller Implementation (ApiControllerImplementation.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MySql.Data.MySqlClient;
using ServiciosRest.Oferta.Models;

namespace ServiciosRest.Oferta
{
    public partial class OfertaIdRequisitosController : IOfertaIdRequisitosController
    {

/// <summary>
		/// obtener requisitos de una oferta, la experiencia es en años - /oferta/{id}/requisitos
		/// </summary>
		/// <param name="Id"></param>
		/// <returns>MultipleOfertaIdRequisitosGet</returns>
        public IHttpActionResult Get([FromUri] string Id)
        {
            MultipleOfertaIdRequisitosGet resp = new MultipleOfertaIdRequisitosGet();
            MySqlConnection connection = null;

            try
            {
                connection = new MySqlConnection("host=localhost; port=3306; user=usuario; password=; database=mtis_final");
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM oferta WHERE id=@id";
                command.Prepare();
                command.Parameters.AddWithValue("@id", Id);
                MySqlDataReader resultSet = command.ExecuteReader();
                Requisitos requisitos = new Requisitos();

                if (resultSet.Read())
                {
                    requisitos.Nombre = resultSet[1].ToString();
                    requisitos.Titulos = resultSet[2].ToString();
                    requisitos.Experiencia = (int)resultSet[3];
                    requisitos.Edad = (int)resultSet[4];
                    resp.Requisitos = requisitos;
                    resultSet.Close();
                    return Ok(resp.Requisitos);
                }

                else
                {
                    resp.ErrorOferta = new ErrorOferta();
                    resp.ErrorOferta.Codigo = 400;
                    resp.ErrorOferta.Mensaje = "No se encuentra una oferta con ese ID";
                    return Content(System.Net.HttpStatusCode.NotFound, resp.ErrorOferta);
                }

            }

            catch (Exception e)
            {
                return InternalServerError();//   Content(System.Net.HttpStatusCode.InternalServerError);
            }
            finally
            {
                if (connection != null)
                    connection.Close();

            }
        }
    }

    
}
