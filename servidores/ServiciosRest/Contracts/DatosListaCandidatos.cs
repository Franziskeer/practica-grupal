// Template: Models (ApiModel.t4) version 5.0

// This code was generated by AMF Server Scaffolder

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace ServiciosRest.ListaCandidatos.Models
{
    /// <summary>
    /// Datos para lista candidatos
    /// </summary>
    public partial class DatosListaCandidatos
    {
        

        [Required]
        [MaxLength(50)]
        [MinLength(0)]
		[JsonProperty("dniDemandante")]
        public string DniDemandante { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(0)]
		[JsonProperty("idOferta")]
        public string IdOferta { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(0)]
		[JsonProperty("puntuacion")]
        public string Puntuacion { get; set; }
    } // end class

} // end Models namespace

