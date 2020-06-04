using ClienteAplicacion.ServiciosMule;
using ClienteAplicacion.ServiciosMule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClienteAplicacion
{
    /// <summary>
    /// Lógica de interacción para CrearDemandante.xaml
    /// </summary>
    public partial class CrearDemandante : Window
    {
        private string respuesta_alta = "";
        private ServiciosMule.ServiciosMuleClient cliente;
        public CrearDemandante()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        { 
            respuesta_alta = "";
            await Crear_demandante();
            MessageBox.Show(respuesta_alta.Count() > 0 ? respuesta_alta : "No se recibió mensaje del servidor.");
            if (respuesta_alta.ToLower().Contains("correctamente"))
                Close();


        }

        private async Task Crear_demandante()
        {
            cliente = new ServiciosMule.ServiciosMuleClient("http://localhost:9092/");
            ServiciosMule.Models.EntradaAltaDemandante entrada = new ServiciosMule.Models.EntradaAltaDemandante
            {
                Dni = inputDni.Text,
                Nombre = inputNombre.Text,
                Apellidos = inputApellidos.Text,
                Telefono = inputTelefono.Text,
                Direccion = inputDireccion.Text,
                Poblacion = inputPoblacion.Text,
                Edad = inputEdad.Text,
                Fecha_nacimiento = inputNacimiento.Text,
                Fecha_renovacion = inputRenovacion.Text,
                Email = inputEmail.Text,
                Pass = inputPass.Text,
                Iban = inputIban.Text,
                Experiencia = inputExperiencia.Text,
                Situacion_laboral = checkSituacionLaboral.IsChecked == true ? "true" : "false",
                Titulos = inputTitulos.Text
            };

            try
            {
                var resultado = await cliente.MuleAltademandante.Post(entrada);
                string mensaje = resultado.Content.ResponseMule.Mensaje;
                respuesta_alta = mensaje.ToString();
            }
            catch (System.Net.Http.HttpRequestException)
            {
                respuesta_alta = "Error conectando con el servidor";
            }

            /*entradaInscripcionOferta.DniDemandante = tbox_inscribir_dni.Text.ToString();
            entradaInscripcionOferta.IdOferta = tbox_inscribir_oferta.Text.ToString();
            var peticion = await cliente.MuleInscribirseoferta.Post(entradaInscripcionOferta);
            respuesta_inscribir = peticion.Content.ResponseMule.Mensaje.ToString();*/
        }
    }
}
