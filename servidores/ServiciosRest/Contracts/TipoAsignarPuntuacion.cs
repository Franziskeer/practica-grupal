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
    /// Tipo de datos que contiene un demandante y una oferta
    /// </summary>
    public partial class TipoAsignarPuntuacion
    {
        

        [Required]
        [MaxLength(50)]
        [MinLength(0)]
		[JsonProperty("demand_dni")]
        public string Demand_dni { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(0)]
		[JsonProperty("demand_edad")]
        public string Demand_edad { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(0)]
		[JsonProperty("demand_titulos")]
        public string Demand_titulos { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(0)]
		[JsonProperty("demand_experiencia")]
        public string Demand_experiencia { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(0)]
		[JsonProperty("ofert_id")]
        public string Ofert_id { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(0)]
		[JsonProperty("ofert_edad")]
        public string Ofert_edad { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(0)]
		[JsonProperty("ofert_titulos")]
        public string Ofert_titulos { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(0)]
		[JsonProperty("ofert_experiencia")]
        public string Ofert_experiencia { get; set; }
    } // end class

} // end Models namespace
