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
    /// Interaction logic for Details.xaml
    /// </summary>
    public partial class Details : Window
    {
        public Details()
        {
            InitializeComponent();
        }
        //private void Details_Loaded(object sender, RoutedEventArgs e)
        //{
        //    string selectedItem = System.Windows.Navigation.NavigationService.GetNavigationData().ToString();
        //    string connestionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Toni\Source\Repos\HinkovT_FinalPr_Sem2.1\HinkovT_FinalPr_Sem2\DB.mdf;Integrated Security=True";
        //    using (SqlConnection connection = new SqlConnection(connestionString))
        //    {
        //        connection.Open();
        //        string query = "SELECT * FROM dbo.[Destinations] WHERE name = "
        //    }
        //}
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            BankDetails bankdetails = new BankDetails();
            bankdetails.Show();
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Pick pick = new Pick();
            pick.Show();
            this.Close();
        }
    }
}
