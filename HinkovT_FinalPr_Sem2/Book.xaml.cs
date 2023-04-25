using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
namespace HinkovT_FinalPr_Sem2
{
    /// <summary>
    /// Interaction logic for Book.xaml
    /// </summary>
    public partial class Book : Window
    {
        public Book()
        {
            InitializeComponent();
        }

        private void Fleet_Click(object sender, RoutedEventArgs e)
        {
            Fleet fleet = new Fleet();
            fleet.Show();
            this.Close();
        }

        private void Destinations_Click(object sender, RoutedEventArgs e)
        {
            Pick pick = new Pick();
            pick.Show();
            this.Close();
        }
    }
}
