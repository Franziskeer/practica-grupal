// Template: Controller Interface (ApiControllerInterface.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ServiciosRest.Demandantes.Models;


namespace ServiciosRest.Demandantes
{
    public interface IDemandanteController
    {

        IHttpActionResult Post([FromBody] ServiciosRest.Demandantes.Models.Demandante demandante);
        IHttpActionResult Get([FromUri] string Dni);
        IHttpActionResult GetByDniSituacionLaboral([FromUri] string Dni);
        IHttpActionResult Put([FromBody] string Ipdefault,[FromUri] string Dni);
        IHttpActionResult PutByDniFechaRenovacion([FromBody] ServiciosRest.Demandantes.Models.EntradaFechaRenovacion entradaFechaRenovacion,[FromUri] string Dni,[FromUri] string restkey);
    }
}
