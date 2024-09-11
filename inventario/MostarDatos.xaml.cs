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
    /// Lógica de interacción para MostarDatos.xaml
    /// </summary>
    public partial class MostarDatos : Page
    {
        public MostarDatos()
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
            string numIngresado = NumDatos.Text;
            int num;
            try
            {
                num = int.Parse(numIngresado);

                if (num < 0)
                {
                    Label.Content = "Ingreso un numero negativo.Por favor ingrese un numero valido";

                }
                if (num == 0)
                {
                    Label.Content = "Ingreso 0.Por favor ingrese un numero valido";

                }
                if (num>0 && num <= 500)
                {
                   
                    Data.NumSet(num);
                    this.NavigationService.Navigate(new OrdenarPor());
                }
                if (num > 500)
                {
                    Data.NumSet(500);
                    this.NavigationService.Navigate(new OrdenarPor());
                }




            }
            catch (FormatException)
            {
                Label.Content = "Por favor ingrese un numero valido";

            }
        }


    }
}
