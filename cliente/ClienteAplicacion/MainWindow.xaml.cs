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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClienteAplicacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string respuesta_renovar="";
        private string respuesta_inscribir = "";
        private ServiciosMule.ServiciosMuleClient cliente;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async Task llamada_servicio_renovacion()
        {
            cliente = new ServiciosMule.ServiciosMuleClient("http://localhost:9092/");
            ServiciosMule.Models.EntradaActualizarFecha entradaActualizarFecha = new ServiciosMule.Models.EntradaActualizarFecha();
            entradaActualizarFecha.DniDemandante = tbox_renovar_dni.Text.ToString();
            entradaActualizarFecha.FechaRenovacion = tbox_renovar_fecha.Text.ToString();
            var peticion = await cliente.MuleRenovarfecha.Post(entradaActualizarFecha);
            respuesta_renovar = peticion.Content.ResponseMule.Mensaje.ToString();
        }

        private async Task llamada_servicio_inscripcion()
        {
            cliente = new ServiciosMule.ServiciosMuleClient("http://localhost:9092/");
            ServiciosMule.Models.EntradaInscripcionOferta entradaInscripcionOferta = new ServiciosMule.Models.EntradaInscripcionOferta();
            entradaInscripcionOferta.DniDemandante = tbox_inscribir_dni.Text.ToString();
            entradaInscripcionOferta.IdOferta = tbox_inscribir_oferta.Text.ToString();
            var peticion = await cliente.MuleInscribirseoferta.Post(entradaInscripcionOferta);
            respuesta_inscribir = peticion.Content.ResponseMule.Mensaje.ToString();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await llamada_servicio_renovacion();
            tbox_renovar_respuesta.Text = respuesta_renovar;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            await llamada_servicio_inscripcion();
            tbox_inscribir_respuesta.Text = respuesta_inscribir;
        }
    }
}
