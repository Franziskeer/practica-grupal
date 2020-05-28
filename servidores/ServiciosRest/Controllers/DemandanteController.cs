// Template: Controller Implementation (ApiControllerImplementation.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MySql.Data.MySqlClient;
using ServiciosRest.Demandantes.Models;

namespace ServiciosRest.Demandantes
{
    public partial class DemandanteController : IDemandanteController
    {

        /// <summary>
        /// Dará de alta un nuevo demandante en el sistema. - /demandante
        /// </summary>
        /// <param name="demandante">Tipo de dato complejo para representar los datos de un demandante</param>
        /// <returns>MultipleDemandantePost</returns>
        public IHttpActionResult Post([FromBody] ServiciosRest.Demandantes.Models.Demandante demandante)
        {
            // TODO: implement Post - route: demandante/demandante
            // var result = new MultipleDemandantePost();
            // return Ok(result);
            return Ok();
        }

        /// <summary>
        /// obtiene el perfil de un demandante - /demandante/{dni}
        /// </summary>
        /// <param name="Dni"></param>
        /// <returns>MultipleDemandanteDniGet</returns>
        public IHttpActionResult Get([FromUri] string Dni)
        {
            // TODO: implement Get - route: demandante/{dni}
            // var result = new MultipleDemandanteDniGet();
            // return Ok(result);
            MultipleDemandanteDniGet resp = new MultipleDemandanteDniGet();
            MySqlConnection connection = null;

            try
            {
                connection = new MySqlConnection("host=localhost; port=3306; user=usuario; password=; database=mtis_final");
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM demandante WHERE dni=@dni";
                command.Prepare();
                command.Parameters.AddWithValue("@dni", Dni);
                MySqlDataReader resultSet = command.ExecuteReader();
                Demandante demandante = new Demandante();

                if (resultSet.Read())
                {
                    demandante.Dni = resultSet[1].ToString();
                    demandante.Pass = resultSet[2].ToString();
                    demandante.Nombre = resultSet[3].ToString();
                    demandante.Apellidos = resultSet[4].ToString();
                    demandante.Direccion = resultSet[5].ToString();
                    demandante.Poblacion = resultSet[6].ToString();
                    demandante.Telefono = resultSet[7].ToString();
                    demandante.Email = resultSet[8].ToString();
                    demandante.Fecha_nacimiento = resultSet[9].ToString();
                    demandante.Fecha_renovacion = resultSet[10].ToString();
                    demandante.Iban = resultSet[11].ToString();
                    demandante.Situacion_laboral = (bool)resultSet[12];
                    demandante.Edad = (int)resultSet[13];
                    demandante.Titulos = resultSet[14].ToString();
                    demandante.Experiencia = (int)resultSet[15];


                    resp.Demandante = demandante;
                    resultSet.Close();
                    return Ok(resp.Demandante);
                }

                else
                {
                    resp.ErrorDemandante = new ErrorDemandante();
                    resp.ErrorDemandante.Codigo = 404;
                    resp.ErrorDemandante.Mensaje = "No se encuentra el demandante con ese DNI";
                    return Content(System.Net.HttpStatusCode.NotFound, resp.ErrorDemandante);
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

        /// <summary>
        /// Devuelve true si la situacion laboral es valida para solicitar un empleo. - /demandante/{dni}/situacionLaboral
        /// </summary>
        /// <param name="Dni"></param>
        /// <returns>MultipleDemandanteDniSituacionLaboralGet</returns>
        public IHttpActionResult GetByDniSituacionLaboral([FromUri] string Dni)
        {
            // TODO: implement GetByDniSituacionLaboral - route: demandante/{dni}/situacionLaboral
            // var result = new MultipleDemandanteDniSituacionLaboralGet();
            // return Ok(result);
            MultipleDemandanteDniSituacionLaboralGet resp = new MultipleDemandanteDniSituacionLaboralGet();
            MySqlConnection connection = null;

            try
            {
                connection = new MySqlConnection("host=localhost; port=3306; user=usuario; password=; database=mtis_final");
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM demandante WHERE dni=@dni";
                command.Prepare();
                command.Parameters.AddWithValue("@dni", Dni);
                MySqlDataReader resultSet = command.ExecuteReader();
                ResponseDemandante response = new ResponseDemandante();

                if (resultSet.Read())
                {
                    response.Estado = (bool)resultSet[12];
                    if (response.Estado)//1 = demandante empleado actualmente
                    {
                        response.Mensaje = "Trabajando";
                    }
                    else
                    {//0 para desempleado
                        response.Mensaje = "Desempleado";
                    }


                    resp.ResponseDemandante = response;
                    resultSet.Close();
                    return Ok(resp.ResponseDemandante);
                }

                else
                {
                    resp.ErrorDemandante = new ErrorDemandante();
                    resp.ErrorDemandante.Codigo = 404;
                    resp.ErrorDemandante.Mensaje = "No se encuentra el demandante con ese DNI";
                    return Content(System.Net.HttpStatusCode.NotFound, resp.ErrorDemandante);
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

        /// <summary>
        /// Modificará la contraseña del demandante. Será útil tanto en el alta de un nuevo usuario como en el caso en que no recuerde su contraseña. - /demandante/{dni}/pass
        /// </summary>
        /// <param name="Ipdefault"></param>
        /// <param name="Dni"></param>
        /// <returns>MultipleDemandanteDniPassPut</returns>
        public IHttpActionResult Put([FromBody] string Ipdefault, [FromUri] string Dni)
        {
            // TODO: implement Put - route: demandante/{dni}/pass
            // var result = new MultipleDemandanteDniPassPut();
            // return Ok(result);
            return Ok();
        }

        /// <summary>
		/// Modificará la fecha de renovación del demandante. Servirá para cuando el demandante decida renovar su estancia en el sistema. - /demandante/{dni}/fechaRenovacion
		/// </summary>
		/// <param name="entradaFechaRenovacion">String con la fecha de renovacion</param>
		/// <param name="Dni"></param>
		/// <param name="restkey"></param>
		/// <returns>MultipleDemandanteDniFechaRenovacionPut</returns>
        public IHttpActionResult PutByDniFechaRenovacion([FromBody] ServiciosRest.Demandantes.Models.EntradaFechaRenovacion entradaFechaRenovacion, [FromUri] string Dni, [FromUri] string restkey)
        {
            // TODO: implement PutByDniFechaRenovacion - route: demandante/{dni}/fechaRenovacion
            // var result = new MultipleDemandanteDniFechaRenovacionPut();
            // return Ok(result);
            MultipleDemandanteDniFechaRenovacionPut resp = new MultipleDemandanteDniFechaRenovacionPut();
            MySqlConnection connection = null;

            try
            {
                connection = new MySqlConnection("host=localhost; port=3306; user=usuario; password=; database=mtis_final");
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE demandante SET fecha_renovacion=@fecha_renovacion " +
                    "WHERE dni=@dni_demandante";

                command.Prepare();
                command.Parameters.AddWithValue("@fecha_renovacion", entradaFechaRenovacion.FechaRenovacion);
                command.Parameters.AddWithValue("@dni_demandante", Dni.ToString());

                if (command.ExecuteNonQuery() > 0)
                {
                    ResponseDemandante respuestaDemandante = new ResponseDemandante();
                    respuestaDemandante.Mensaje = "Se ha modificado la fecha de renovacion correctamente";
                    respuestaDemandante.Estado = true;
                    return Created("", respuestaDemandante);
                }

                else
                {
                    resp.ErrorDemandante = new ErrorDemandante();
                    resp.ErrorDemandante.Codigo = 400;
                    resp.ErrorDemandante.Mensaje = "Error al modificar la fecha de renovacion";

                    return Content(System.Net.HttpStatusCode.BadRequest, resp.ErrorDemandante);
                }

            }

            catch (Exception e)
            {
                resp.ErrorDemandante = new ErrorDemandante();
                resp.ErrorDemandante.Codigo = 400;
                resp.ErrorDemandante.Mensaje = "Error al modificar la fecha de renovacion: " + e.Message.ToString();

                return Content(System.Net.HttpStatusCode.BadRequest, resp.ErrorDemandante);
            }

            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}
