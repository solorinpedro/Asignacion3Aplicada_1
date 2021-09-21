using Asignacion3Aplicada_1;
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
using Asignacion3Aplicada1;

namespace Asignacion3Aplicada1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AplicacionJagged_Click(object sender, RoutedEventArgs e)
        {
            ArregloJagged arreglojagged = new ArregloJagged();
            arreglojagged.Show();
        }

        private void EjercicioEscuela_Click(object sender, RoutedEventArgs e)
        {
            ArregloEscuela arregloEscuela = new ArregloEscuela();
            arregloEscuela.Show();
        }

        private void Arreglo_como_Parametro_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5 ejercicio5 = new Ejercicio5();
            ejercicio5.Show();
        }

        private void Ejerciocio1_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1 ejercicio = new Ejercicio1();
            ejercicio.Show();
        }

        private void HashTable_Click(object sender, RoutedEventArgs e)
        {
            TablaHash tabla = new TablaHash();
            tabla.Show();
        }

        private void AgendaTelefonica_Click(object sender, RoutedEventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();

        }
    }
}
