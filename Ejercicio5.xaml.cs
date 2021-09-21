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
using System.Windows.Shapes;

namespace Asignacion3Aplicada_1
{
    /// <summary>
    /// Interaction logic for Ejercio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        private int[] Elementos;
        private int count = 0;
        public Ejercicio5()
        {
            Elementos = new int[10];
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            Elementos[count] = int.Parse(ElementostextBox.Text);
            count = count + 1;
        }

        private void ImprimirButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ElementosListbox.Items.Add(Elementos[i]);
            }
        }
    }
}
