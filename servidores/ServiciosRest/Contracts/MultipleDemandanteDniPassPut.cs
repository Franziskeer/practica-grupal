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
    /// Multiple Response Types ResponseDemandante, ErrorDemandante
    /// </summary>
    public partial class MultipleDemandanteDniPassPut
    {
        

        /// <summary>
        ///  Tipo de dato complejo para representar una respuesta válida
        /// </summary>

        public ResponseDemandante ResponseDemandante { get; set; }

        /// <summary>
        ///  Tipo de dato complejo para representar una respuesta errónea
        /// </summary>

        public ErrorDemandante ErrorDemandante { get; set; }
    } // end class

} // end Models namespace

