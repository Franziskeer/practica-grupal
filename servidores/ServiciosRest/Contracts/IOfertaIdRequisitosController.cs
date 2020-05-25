// Template: Controller Interface (ApiControllerInterface.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ServiciosRest.Oferta.Models;


namespace ServiciosRest.Oferta
{
    public interface IOfertaIdRequisitosController
    {

        IHttpActionResult Get([FromUri] string Id);
    }
}
