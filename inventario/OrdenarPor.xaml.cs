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
    /// Lógica de interacción para OrdenarPor.xaml
    /// </summary>
    public partial class OrdenarPor : Page
    {
        public OrdenarPor()
        {
            InitializeComponent();
        }
        private void VistaData(object sender, RoutedEventArgs e)
        {
            Button botonClick = sender as Button;
            string nombreBoton = botonClick.Name;
            Data.BotonSet(nombreBoton);
            this.NavigationService.Navigate(new VisData());

        }
        private void Regresar(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new pagina1());
        }
        private void Anterior(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MostarDatos());
        }
    }
}
