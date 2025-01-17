// Template: Base Controller (ApiControllerBase.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ServiciosRest.Demandantes.Models;

// Do not modify this file. This code was generated by AMF Server Scaffolder

namespace ServiciosRest.Demandantes
{
    [RoutePrefix("demandante")]
    public partial class DemandanteController : ApiController
    {


/// <summary>
		/// Dará de alta un nuevo demandante en el sistema. - /demandante
		/// </summary>
		/// <param name="demandante">Tipo de dato complejo para representar los datos de un demandante</param>
		/// <returns>MultipleDemandantePost</returns>
        [ResponseType(typeof(MultipleDemandantePost))]
        [HttpPost]
        [Route("demandante")]
        public virtual IHttpActionResult PostBase([FromBody] ServiciosRest.Demandantes.Models.Demandante demandante)
        {
            // Do not modify this code
                        return  ((IDemandanteController)this).Post(demandante);
                    }

/// <summary>
		/// obtiene el perfil de un demandante - /demandante/{dni}
		/// </summary>
		/// <param name="Dni"></param>
		/// <returns>MultipleDemandanteDniGet</returns>
        [ResponseType(typeof(MultipleDemandanteDniGet))]
        [HttpGet]
        [Route("{dni}")]
        public virtual IHttpActionResult GetBase([FromUri] string Dni)
        {
            // Do not modify this code
                        return  ((IDemandanteController)this).Get(Dni);
                    }

/// <summary>
		/// Devuelve true si la situacion laboral es valida para solicitar un empleo. - /demandante/{dni}/situacionLaboral
		/// </summary>
		/// <param name="Dni"></param>
		/// <returns>MultipleDemandanteDniSituacionLaboralGet</returns>
        [ResponseType(typeof(MultipleDemandanteDniSituacionLaboralGet))]
        [HttpGet]
        [Route("{dni}/situacionLaboral")]
        public virtual IHttpActionResult GetByDniSituacionLaboralBase([FromUri] string Dni)
        {
            // Do not modify this code
                        return  ((IDemandanteController)this).GetByDniSituacionLaboral(Dni);
                    }

/// <summary>
		/// Modificará la contraseña del demandante. Será útil tanto en el alta de un nuevo usuario como en el caso en que no recuerde su contraseña. - /demandante/{dni}/pass
		/// </summary>
		/// <param name="Ipdefault"></param>
		/// <param name="Dni"></param>
		/// <returns>MultipleDemandanteDniPassPut</returns>
        [ResponseType(typeof(MultipleDemandanteDniPassPut))]
        [HttpPut]
        [Route("{dni}/pass")]
        public virtual IHttpActionResult PutBase([FromBody] string Ipdefault,[FromUri] string Dni)
        {
            // Do not modify this code
                        return  ((IDemandanteController)this).Put(Ipdefault,Dni);
                    }

/// <summary>
		/// Modificará la fecha de renovación del demandante. Servirá para cuando el demandante decida renovar su estancia en el sistema. - /demandante/{dni}/fechaRenovacion
		/// </summary>
		/// <param name="entradaFechaRenovacion">String con la fecha de renovacion</param>
		/// <param name="Dni"></param>
		/// <param name="restkey"></param>
		/// <returns>MultipleDemandanteDniFechaRenovacionPut</returns>
        [ResponseType(typeof(MultipleDemandanteDniFechaRenovacionPut))]
        [HttpPut]
        [Route("{dni}/fechaRenovacion")]
        public virtual IHttpActionResult PutByDniFechaRenovacionBase([FromBody] ServiciosRest.Demandantes.Models.EntradaFechaRenovacion entradaFechaRenovacion,[FromUri] string Dni,[FromUri] string restkey)
        {
            // Do not modify this code
                        return  ((IDemandanteController)this).PutByDniFechaRenovacion(entradaFechaRenovacion,Dni,restkey);
                    }
    }
}
