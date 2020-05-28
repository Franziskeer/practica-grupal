// Template: Models (ApiModel.t4) version 5.0

// This code was generated by AMF Server Scaffolder

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace ServiciosRest.Demandantes.Models
{
    /// <summary>
    /// String con la fecha de renovacion
    /// </summary>
    public partial class EntradaFechaRenovacion
    {
        

        [Required]
        [MaxLength(40)]
        [MinLength(0)]
		[JsonProperty("fechaRenovacion")]
        public string FechaRenovacion { get; set; }
    } // end class

} // end Models namespace

