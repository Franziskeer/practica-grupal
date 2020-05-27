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
    /// requisitos de una oferta
    /// </summary>
    public partial class Oferta
    {
        

        [Required]
        [MaxLength(0)]
        [MinLength(0)]
		[JsonProperty("nombre")]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(0)]
        [MinLength(0)]
		[JsonProperty("edad")]
        public int Edad { get; set; }

        [Required]
        [MaxLength(0)]
        [MinLength(0)]
		[JsonProperty("titulos")]
        public string Titulos { get; set; }

        [Required]
        [MaxLength(0)]
        [MinLength(0)]
		[JsonProperty("experiencia")]
        public int Experiencia { get; set; }
    } // end class

} // end Models namespace
