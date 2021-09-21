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
    /// Interaction logic for Agenda.xaml
    /// </summary>
    public partial class Agenda : Window
    {
        List<String> AgendaTelefonica;
        public Agenda()
        {
            AgendaTelefonica = new List<String>();
            InitializeComponent();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            foreach (var datos in AgendaTelefonica)
            {
                NombreTextBox.Text = AgendaTelefonica.ToString();
                TelefonoTextBox.Text = AgendaTelefonica.ToString();
                emailTextBox.Text = AgendaTelefonica.ToString();
                CasaTextbox.Text = AgendaTelefonica.ToString();

            }
        }
    }
}
