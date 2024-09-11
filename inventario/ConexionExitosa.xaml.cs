using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
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

namespace inventario
{
    /// <summary>
    /// Lógica de interacción para ConexionExitosa.xaml
    /// </summary>
    public partial class ConexionExitosa : Page
    {
        public static bool isFinish;
        public  ConexionExitosa()
        {
            InitializeComponent();
            Conexion();





        }

        private void Datos (object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MostarDatos());

        }
        private void RegresarInicio(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new pagina1());

        }

        private void Buscar(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BuscarDatos());
        }
        

        private async Task<string> HttpRequeste(string url)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage respuesta = await client.GetAsync(url);
            respuesta.EnsureSuccessStatusCode();
            string respCuerpo = await respuesta.Content.ReadAsStringAsync();
           
            return respCuerpo;


        }
        private async Task <string> Conexion()
        {
            try
            {


                string respuestaCuerpo = await HttpRequeste(Data.Url_get());
                Resultado[] listaResultados = JsonSerializer.Deserialize<Resultado[]>(respuestaCuerpo);
                Data.ResultSet(listaResultados);
                OcultarElementos();

                return respuestaCuerpo;

               


            }
            catch (HttpRequestException ex)
            {
                return "Error";
            }

            catch (JsonException ex)
            {
                return "Error";
            }
        }

        private void OcultarElementos()
        {
            Barra.Visibility = Visibility.Collapsed;
            Label1.Visibility = Visibility.Collapsed;
            Boton_Buscar.Visibility = Visibility.Visible;
            Label2.Visibility = Visibility.Visible;
            Boton_Datos.Visibility = Visibility.Visible;
        }

        private void Error()
        {
            Barra.Visibility = Visibility.Collapsed;
            Regresar.Visibility = Visibility.Visible;
            Label1.Content = "Error, Regrese al inicio e intente de nuevo";


        }
    }
}
