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
    /// Lógica de interacción para ResultadoBusqueda.xaml
    /// </summary>
    public partial class ResultadoBusqueda : Page
    {
        public ResultadoBusqueda()
        {
            InitializeComponent();
            textblock.Text=Data.SearchData(Data.Id_Get(), Data.Email_Get(), Data.Result_get());
        }
        private void Regresar(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new pagina1());
        }
        private void Anterior(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BuscarDatos());
        }
    }

}
