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
    /// Interaction logic for Pick.xaml
    /// </summary>
    public partial class Pick : Window
    {
        public Pick()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            //Details details = new Details();
            //details.Show();
            //this.Close();
            //string selectedItem = ((ComboBoxItem)comboBox.SelectedItem).Content.ToString();
            //System.Windows.Navigation.NavigationService.Navigate(new Details(selectedItem));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            book.Show();
            this.Close();
        }
    }
}
