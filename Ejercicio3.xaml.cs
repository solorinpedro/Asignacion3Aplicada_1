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
    /// Interaction logic for Ejercicio3.xaml
    /// </summary>
    public partial class ArregloJagged : Window
    {
        private Double[] alumnos;
        private Double Promedio;
        private Double Mayor = 0;
        private Double Menor = 0;
        private Double Suma = 0;
        private int count = 0;
        public ArregloJagged()
        {
            InitializeComponent();
            alumnos = new Double[5]; 
        }

        private void ButtonCalcular_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Suma += alumnos[i];
                if(alumnos[i] > Mayor)
                {
                    Mayor = alumnos[i];
                }
                if(alumnos[i] < Menor)
                {
                    Menor = alumnos[i];
                }
            }

            CalificacionMayorTextBOx.Text = Mayor.ToString();
            CalificacionMenorTextBox.Text = Menor.ToString();
            Promedio = Suma / 5;
            PromedioTextbox.Text = Promedio.ToString();
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            alumnos[count] = Double.Parse(CalificacionesTextbox.Text);
            count = count + 1;
        }
    }
}
