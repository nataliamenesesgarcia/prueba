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

namespace inventario
{
    /// <summary>
    /// Lógica de interacción para BuscarDatos.xaml
    /// </summary>
    public partial class BuscarDatos : Page
    {
        public BuscarDatos()
        {
            InitializeComponent();
        }
        private void Regresar(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new pagina1());
        }
        private void Anterior(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ConexionExitosa());
        }
        private void Confirmar(object sender, RoutedEventArgs e)
        {
            string idIngresado = dataId.Text;
            string emailIngresado = dataEmail.Text;
            Data.EmailSet(emailIngresado);
            int num;

            try
            {
                num = int.Parse(idIngresado);
                Data.IdSet(num);
                this.NavigationService.Navigate(new ResultadoBusqueda());

            }
            catch (FormatException)
            {
                Label.Content = "Ingrese un ID válido";

            }
           
        }
    }
}
