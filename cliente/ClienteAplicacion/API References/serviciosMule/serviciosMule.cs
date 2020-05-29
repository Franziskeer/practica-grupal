// Template: Client Proxy T4 Template (RAMLClient.t4) version 7.0

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RAML.Api.Core;
using ClienteAplicacion.ServiciosMule.Models;

namespace ClienteAplicacion.ServiciosMule
{
    public partial class MuleRenovarfecha
    {
        private readonly ServiciosMuleClient proxy;

        internal MuleRenovarfecha(ServiciosMuleClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// actualizar la fecha de renovacion de un demandante - /mule/renovarfecha
		/// </summary>
		/// <param name="entradaActualizarFecha">contiene un dni y una fecha de renovacion</param>
        public virtual async Task<ClienteAplicacion.ServiciosMule.Models.MuleRenovarfechaPostResponse> Post(ClienteAplicacion.ServiciosMule.Models.EntradaActualizarFecha entradaActualizarFecha)
        {

            var url = "/mule/renovarfecha";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url.StartsWith("/") ? url.Substring(1) : url);
            req.Content = new ObjectContent(typeof(ClienteAplicacion.ServiciosMule.Models.EntradaActualizarFecha), entradaActualizarFecha, new JsonMediaTypeFormatter());                           
	        var response = await proxy.Client.SendAsync(req);

            return new ClienteAplicacion.ServiciosMule.Models.MuleRenovarfechaPostResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// actualizar la fecha de renovacion de un demandante - /mule/renovarfecha
		/// </summary>
		/// <param name="request">ClienteAplicacion.ServiciosMule.Models.MuleRenovarfechaPostRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<ClienteAplicacion.ServiciosMule.Models.MuleRenovarfechaPostResponse> Post(ClienteAplicacion.ServiciosMule.Models.MuleRenovarfechaPostRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "/mule/renovarfecha";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url.StartsWith("/") ? url.Substring(1) : url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
            if(request.Formatter == null)
                request.Formatter = new JsonMediaTypeFormatter();

			req.Content = new ObjectContent(typeof(EntradaActualizarFecha), request.Content, request.Formatter);
	        var response = await proxy.Client.SendAsync(req);
            return new ClienteAplicacion.ServiciosMule.Models.MuleRenovarfechaPostResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }

    }

    public partial class MuleInscribirseoferta
    {
        private readonly ServiciosMuleClient proxy;

        internal MuleInscribirseoferta(ServiciosMuleClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// inscripcion a una oferta de un demandante - /mule/inscribirseoferta
		/// </summary>
		/// <param name="entradaInscripcionOferta">contiene un dni y el id de una oferta</param>
        public virtual async Task<ClienteAplicacion.ServiciosMule.Models.MuleInscribirseofertaPostResponse> Post(ClienteAplicacion.ServiciosMule.Models.EntradaInscripcionOferta entradaInscripcionOferta)
        {

            var url = "/mule/inscribirseoferta";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url.StartsWith("/") ? url.Substring(1) : url);
            req.Content = new ObjectContent(typeof(ClienteAplicacion.ServiciosMule.Models.EntradaInscripcionOferta), entradaInscripcionOferta, new JsonMediaTypeFormatter());                           
	        var response = await proxy.Client.SendAsync(req);

            return new ClienteAplicacion.ServiciosMule.Models.MuleInscribirseofertaPostResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// inscripcion a una oferta de un demandante - /mule/inscribirseoferta
		/// </summary>
		/// <param name="request">ClienteAplicacion.ServiciosMule.Models.MuleInscribirseofertaPostRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<ClienteAplicacion.ServiciosMule.Models.MuleInscribirseofertaPostResponse> Post(ClienteAplicacion.ServiciosMule.Models.MuleInscribirseofertaPostRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "/mule/inscribirseoferta";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url.StartsWith("/") ? url.Substring(1) : url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
            if(request.Formatter == null)
                request.Formatter = new JsonMediaTypeFormatter();

			req.Content = new ObjectContent(typeof(EntradaInscripcionOferta), request.Content, request.Formatter);
	        var response = await proxy.Client.SendAsync(req);
            return new ClienteAplicacion.ServiciosMule.Models.MuleInscribirseofertaPostResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }

    }

    /// <summary>
    /// Main class for grouping root resources. Nested resources are defined as properties. The constructor can optionally receive an URL and HttpClient instance to override the default ones.
    /// </summary>
    public partial class ServiciosMuleClient
    {

		public SchemaValidationSettings SchemaValidation { get; private set; } 

        protected readonly HttpClient client;
        public const string BaseUri = "localhost:9092/";

        internal HttpClient Client { get { return client; } }




        public ServiciosMuleClient(string endpointUrl)
        {
            SchemaValidation = new SchemaValidationSettings
			{
				Enabled = true,
				RaiseExceptions = true
			};

			if(string.IsNullOrWhiteSpace(endpointUrl))
                throw new ArgumentException("You must specify the endpoint URL", "endpointUrl");

			if (endpointUrl.Contains("{"))
			{
				var regex = new Regex(@"\{([^\}]+)\}");
				var matches = regex.Matches(endpointUrl);
				var parameters = new List<string>();
				foreach (Match match in matches)
				{
					parameters.Add(match.Groups[1].Value);
				}
				throw new InvalidOperationException("Please replace parameter/s " + string.Join(", ", parameters) + " in the URL before passing it to the constructor ");
			}

            if (!endpointUrl.EndsWith("/"))
                endpointUrl += "/";

            client = new HttpClient {BaseAddress = new Uri(endpointUrl)};
        }

        public ServiciosMuleClient(HttpClient httpClient)
        {
            if(httpClient.BaseAddress == null)
                throw new InvalidOperationException("You must set the BaseAddress property of the HttpClient instance");

            client = httpClient;

			SchemaValidation = new SchemaValidationSettings
			{
				Enabled = true,
				RaiseExceptions = true
			};
        }

        

        public virtual MuleRenovarfecha MuleRenovarfecha
        {
            get { return new MuleRenovarfecha(this); }
        }
                

        public virtual MuleInscribirseoferta MuleInscribirseoferta
        {
            get { return new MuleInscribirseoferta(this); }
        }
                


		public void AddDefaultRequestHeader(string name, string value)
		{
			client.DefaultRequestHeaders.Add(name, value);
		}

		public void AddDefaultRequestHeader(string name, IEnumerable<string> values)
		{
			client.DefaultRequestHeaders.Add(name, values);
		}

        // root methods



    }

} // end namespace









namespace ClienteAplicacion.ServiciosMule.Models
{
    /// <summary>
    /// contiene un dni y una fecha de renovacion
    /// </summary>
    public partial class  EntradaActualizarFecha 
    {

		[JsonProperty("dniDemandante")]
        public string DniDemandante { get; set; }


		[JsonProperty("fechaRenovacion")]
        public string FechaRenovacion { get; set; }


    } // end class

    /// <summary>
    /// contiene un dni y el id de una oferta
    /// </summary>
    public partial class  EntradaInscripcionOferta 
    {

		[JsonProperty("dniDemandante")]
        public string DniDemandante { get; set; }


		[JsonProperty("idOferta")]
        public string IdOferta { get; set; }


    } // end class

    /// <summary>
    /// Tipo de dato complejo para representar una respuesta
    /// </summary>
    public partial class  ResponseMule 
    {

		[JsonProperty("estado")]
        public bool Estado { get; set; }


		[JsonProperty("mensaje")]
        public string Mensaje { get; set; }


    } // end class

    /// <summary>
    /// Multiple Response Types ResponseMule, ResponseMule404
    /// </summary>
    public partial class  MultipleMuleRenovarfechaPost : ApiMultipleResponse
    {
        static readonly Dictionary<string, string> schemas = new Dictionary<string, string>
        {
		};
        
		public static string GetSchema(string statusCode)
        {
            if(schemas.ContainsKey(statusCode))
                return schemas[statusCode];

            if(schemas.ContainsKey("default"))
                return schemas["default"];
                
            return string.Empty;
        }
        
        public MultipleMuleRenovarfechaPost()
        {
            names.Add("200", "ResponseMule");
            types.Add("200", typeof(ResponseMule));
            names.Add("404", "ResponseMule404");
            types.Add("404", typeof(ResponseMule));
        }

        /// <summary>
        ///  Tipo de dato complejo para representar una respuesta
        /// </summary>

        public ResponseMule ResponseMule { get; set; }


        /// <summary>
        ///  Tipo de dato complejo para representar una respuesta
        /// </summary>

        public ResponseMule ResponseMule404 { get; set; }


    } // end class

    /// <summary>
    /// Multiple Response Types ResponseMule, ResponseMule404
    /// </summary>
    public partial class  MultipleMuleInscribirseofertaPost : ApiMultipleResponse
    {
        static readonly Dictionary<string, string> schemas = new Dictionary<string, string>
        {
		};
        
		public static string GetSchema(string statusCode)
        {
            if(schemas.ContainsKey(statusCode))
                return schemas[statusCode];

            if(schemas.ContainsKey("default"))
                return schemas["default"];
                
            return string.Empty;
        }
        
        public MultipleMuleInscribirseofertaPost()
        {
            names.Add("200", "ResponseMule");
            types.Add("200", typeof(ResponseMule));
            names.Add("404", "ResponseMule404");
            types.Add("404", typeof(ResponseMule));
        }

        /// <summary>
        ///  Tipo de dato complejo para representar una respuesta
        /// </summary>

        public ResponseMule ResponseMule { get; set; }


        /// <summary>
        ///  Tipo de dato complejo para representar una respuesta
        /// </summary>

        public ResponseMule ResponseMule404 { get; set; }


    } // end class

    /// <summary>
    /// Request object for method Post of class MuleRenovarfecha
    /// </summary>
    public partial class MuleRenovarfechaPostRequest : ApiRequest
    {
        public MuleRenovarfechaPostRequest(EntradaActualizarFecha Content = null, MediaTypeFormatter Formatter = null)
        {
            this.Content = Content;
            this.Formatter = Formatter;
        }


        /// <summary>
        /// Request content
        /// </summary>
        public EntradaActualizarFecha Content { get; set; }

        /// <summary>
        /// Request formatter
        /// </summary>
        public MediaTypeFormatter Formatter { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Post of class MuleInscribirseoferta
    /// </summary>
    public partial class MuleInscribirseofertaPostRequest : ApiRequest
    {
        public MuleInscribirseofertaPostRequest(EntradaInscripcionOferta Content = null, MediaTypeFormatter Formatter = null)
        {
            this.Content = Content;
            this.Formatter = Formatter;
        }


        /// <summary>
        /// Request content
        /// </summary>
        public EntradaInscripcionOferta Content { get; set; }

        /// <summary>
        /// Request formatter
        /// </summary>
        public MediaTypeFormatter Formatter { get; set; }

    } // end class

    /// <summary>
    /// Response object for method Post of class MuleRenovarfecha
    /// </summary>

    public partial class MuleRenovarfechaPostResponse : ApiResponse
    {

	    private MultipleMuleRenovarfechaPost typedContent;
        /// <summary>
        /// Typed response content
        /// </summary>
        public MultipleMuleRenovarfechaPost Content 
	    {
	        get
	        {
		        if (typedContent != null) 
					return typedContent;

		        typedContent = new MultipleMuleRenovarfechaPost();

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    var content = new XmlSerializer(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode))).Deserialize(xmlStream);
                    typedContent.SetPropertyByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode), content);
                }
                else
                {
		            var task = Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode)), Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode))).ConfigureAwait(false);
		        
		            var content = task.GetAwaiter().GetResult();
                    typedContent.SetPropertyByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode), content);
                }

		        return typedContent;
	        }
    	}  
		
		public static string GetSchema(string statusCode)
        {
            return MultipleMuleRenovarfechaPost.GetSchema(statusCode);
        }      

    } // end class

    /// <summary>
    /// Response object for method Post of class MuleInscribirseoferta
    /// </summary>

    public partial class MuleInscribirseofertaPostResponse : ApiResponse
    {

	    private MultipleMuleInscribirseofertaPost typedContent;
        /// <summary>
        /// Typed response content
        /// </summary>
        public MultipleMuleInscribirseofertaPost Content 
	    {
	        get
	        {
		        if (typedContent != null) 
					return typedContent;

		        typedContent = new MultipleMuleInscribirseofertaPost();

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    var content = new XmlSerializer(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode))).Deserialize(xmlStream);
                    typedContent.SetPropertyByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode), content);
                }
                else
                {
		            var task = Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode)), Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode))).ConfigureAwait(false);
		        
		            var content = task.GetAwaiter().GetResult();
                    typedContent.SetPropertyByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode), content);
                }

		        return typedContent;
	        }
    	}  
		
		public static string GetSchema(string statusCode)
        {
            return MultipleMuleInscribirseofertaPost.GetSchema(statusCode);
        }      

    } // end class


} // end Models namespace
