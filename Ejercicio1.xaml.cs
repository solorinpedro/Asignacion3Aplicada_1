using System;
using System.Collections;
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
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        List<Double> calificaciones;
        private Double Promedio;
        private Double Mayor = 0;
        private Double Menor = 0;
        private Double Suma = 0;
        private int count = 0;
        public Ejercicio1()
        {
            calificaciones = new List<Double>();
            InitializeComponent();
        }

        private void Buttonimprimir_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < calificaciones.Count; i++)
            {
                Suma += calificaciones[i];
                Suma += calificaciones[i];
                if (calificaciones[i] > Mayor)
                {
                    Mayor = calificaciones[i];
                }
                if (calificaciones[i] < Menor)
                {
                    Menor = calificaciones[i];
                }
            }

            CalificacionMayorTextBOx.Text = Mayor.ToString();
            CalificacionMenorTextBox.Text = Menor.ToString();
            Promedio = Suma / 10;
            PromedioTextbox.Text = Promedio.ToString();
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            calificaciones.Add(int.Parse(CalificacionesTextbox.Text));
            count = count + 1;
        }
    }
}
