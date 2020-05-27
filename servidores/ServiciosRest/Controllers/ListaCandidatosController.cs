// Template: Controller Implementation (ApiControllerImplementation.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MySql.Data.MySqlClient;
using ServiciosRest.ListaCandidatos.Models;

namespace ServiciosRest.ListaCandidatos
{
    public partial class ListaCandidatosController : IListaCandidatosController
    {

/// <summary>
		/// proceso para inscribir un demandante de empleo en una oferta - /listaCandidatos
		/// </summary>
		/// <param name="datosListaCandidatos">Datos para lista candidatos</param>
		/// <returns>MultipleListaCandidatosPost</returns>
        public IHttpActionResult Post([FromBody] ServiciosRest.ListaCandidatos.Models.DatosListaCandidatos datosListaCandidatos)
        {
            // TODO: implement Post - route: listaCandidatos/listaCandidatos
            // var result = new MultipleListaCandidatosPost();
            // return Ok(result);
            MultipleListaCandidatosPost resp = new MultipleListaCandidatosPost();
            MySqlConnection connection = null;

            try
            {
                connection = new MySqlConnection("host=localhost; port=3306; user=usuario; password=; database=mtis_final");
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO lista_candidatos(id_oferta, dni_demandante, puntuacion) VALUES(@id_oferta, @dni_demandante, @puntuacion)";

                command.Prepare();
                command.Parameters.AddWithValue("@id_oferta", datosListaCandidatos.IdOferta);
                command.Parameters.AddWithValue("@dni_demandante", datosListaCandidatos.DniDemandante);
                command.Parameters.AddWithValue("@puntuacion", datosListaCandidatos.Puntuacion);
                command.ExecuteNonQuery();

                ResponseDatosListaCandidatos respuestaLista = new ResponseDatosListaCandidatos();
                respuestaLista.Mensaje = "Candidato añadido correctamente";
                respuestaLista.Estado = true;
                return Created("", respuestaLista);
            }

            catch (Exception e)
            {
                resp.ErrorDatosListaCandidatos = new ErrorDatosListaCandidatos();
                resp.ErrorDatosListaCandidatos.Codigo = 400;
                resp.ErrorDatosListaCandidatos.Mensaje = "No se ha podido añadir a lista"+ e.Message.ToString();

                return Content(System.Net.HttpStatusCode.BadRequest, resp.ErrorDatosListaCandidatos);
            }

            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

/// <summary>
		/// proceso para inscribir un demandante de empleo en una oferta - /listaCandidatos
		/// </summary>
		/// <param name="datosListaCandidatos">Datos para lista candidatos</param>
		/// <returns>MultipleListaCandidatosPut</returns>
        public IHttpActionResult Put([FromBody] ServiciosRest.ListaCandidatos.Models.DatosListaCandidatos datosListaCandidatos)
        {
            // TODO: implement Put - route: listaCandidatos/listaCandidatos
            // var result = new MultipleListaCandidatosPut();
            // return Ok(result);
            MultipleListaCandidatosPut resp = new MultipleListaCandidatosPut();
            MySqlConnection connection = null;

            try
            {
                connection = new MySqlConnection("host=localhost; port=3306; user=usuario; password=; database=mtis_final");
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE lista_candidatos SET id_oferta=@id_oferta, dni_demandante=@dni_demandante, puntuacion=@puntuacion "+
                    "WHERE id_oferta=@id_oferta and dni_demandante=@dni_demandante";

                command.Prepare();
                command.Parameters.AddWithValue("@id_oferta", datosListaCandidatos.IdOferta);
                command.Parameters.AddWithValue("@dni_demandante", datosListaCandidatos.DniDemandante);
                command.Parameters.AddWithValue("@puntuacion", datosListaCandidatos.Puntuacion );

                if (command.ExecuteNonQuery() > 0)
                {
                    ResponseDatosListaCandidatos respuestaLista = new ResponseDatosListaCandidatos();
                    respuestaLista.Mensaje = "Se ha modificado la lista correctamente";
                    respuestaLista.Estado = true;
                    return Created("", respuestaLista);
                }

                else
                {
                    resp.ErrorDatosListaCandidatos = new ErrorDatosListaCandidatos();
                    resp.ErrorDatosListaCandidatos.Codigo = 400;
                    resp.ErrorDatosListaCandidatos.Mensaje = "Error al modificar lista candidatos";

                    return Content(System.Net.HttpStatusCode.BadRequest, resp.ErrorDatosListaCandidatos);
                }

            }

            catch (Exception e)
            {
                resp.ErrorDatosListaCandidatos = new ErrorDatosListaCandidatos();
                resp.ErrorDatosListaCandidatos.Codigo = 400;
                resp.ErrorDatosListaCandidatos.Mensaje = "Error al modificar lista candidatos"+e.Message.ToString();

                return Content(System.Net.HttpStatusCode.BadRequest, resp.ErrorDatosListaCandidatos);
            }

            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

    }
}
