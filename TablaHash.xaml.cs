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
    /// Interaction logic for TablaHash.xaml
    /// </summary>
    public partial class TablaHash : Window
    {
        Hashtable diccionario;
        public TablaHash()
        {
            diccionario = new Hashtable();
            InitializeComponent();
        }

        private void AddWord_Click(object sender, RoutedEventArgs e)
        {
            diccionario.Add(PalabraTextBox,"Lebron es el mejor jugador de la nba");
            diccionario.Add(PalabraTextBox.Text,"Carlos mejor conocido como el mancurry es un joven el cual no sabe jugar videos juegos");
            diccionario.Add(PalabraTextBox.Text, "La felicidad es la sensacion de sentirse alegre");
            diccionario.Add(PalabraTextBox.Text,"Gamer es el termino dado a los jovenes que les gusta jugar mucho");
        }

        private void Valor_Click(object sender, RoutedEventArgs e)
        {
            foreach (DictionaryEntry datos in diccionario.Keys)
            {

            }
            DefinicionTextBox.Text = diccionario.Keys.ToString();
        }
    }
}
