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
    /// Lógica de interacción para VisData.xaml
    /// </summary>
    public partial class VisData : Page
    {
        public VisData()
        {
            InitializeComponent();

            Resultado[] dataresults = Data.GetData(Data.num_get(),Data.Result_get(), Data.boton_get());

            listResult.ItemsSource = dataresults;
        }

        private void Regresar(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new pagina1());
        }
        private void Anterior(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new OrdenarPor());
        }
    }
}
