﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
    /// Lógica de interacción para pagina1.xaml
    /// </summary>
    public partial class pagina1 : Page
    {
        public pagina1()
        {
            InitializeComponent();
        }
        private  void Confirmar(object sender, RoutedEventArgs e)
        {
            

            string url = productoNombre.Text;
           Data.Url_set(url);
            this.NavigationService.Navigate(new ConexionExitosa());

        }
        

        


    }
}
