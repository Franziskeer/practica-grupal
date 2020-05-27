// Template: Controller Interface (ApiControllerInterface.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ServiciosRest.ListaCandidatos.Models;


namespace ServiciosRest.ListaCandidatos
{
    public interface IListaCandidatosController
    {

        IHttpActionResult Post([FromBody] ServiciosRest.ListaCandidatos.Models.DatosListaCandidatos datosListaCandidatos);
        IHttpActionResult Put([FromBody] ServiciosRest.ListaCandidatos.Models.DatosListaCandidatos datosListaCandidatos);
    }
}
