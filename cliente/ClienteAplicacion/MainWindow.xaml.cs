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
        private string respuesta="";
        private ServiciosMule.ServiciosMuleClient cliente;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async Task llamada_servicio()
        {
            cliente = new ServiciosMule.ServiciosMuleClient("http://localhost:9092/");
            ServiciosMule.Models.EntradaActualizarFecha entradaActualizarFecha = new ServiciosMule.Models.EntradaActualizarFecha();
            entradaActualizarFecha.DniDemandante = textbox_dni.Text.ToString();
            entradaActualizarFecha.FechaRenovacion = textbox_fecha.Text.ToString();
            var peticion = await cliente.MuleRenovarfecha.Post(entradaActualizarFecha);
            respuesta = peticion.Content.ResponseMule.Mensaje.ToString();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await llamada_servicio();
            textbox_respuesta.Text = respuesta;
        }
    }
}
