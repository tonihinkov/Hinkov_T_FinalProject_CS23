using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
using System.Xml.Linq;

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
            SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Toni\Source\Repos\HinkovT_FinalPr_Sem2.1\HinkovT_FinalPr_Sem2\DB.mdf; Integrated Security = True");

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    string query = "SELECT * FROM dbo.[Destinations] WHERE name = '" + this.comboBox.Text + "'";
            //    SqlCommand command = new SqlCommand(query, connection);
            //    //command.Parameters.AddWithValue("@courseID", courseID);

            //    Details di = new Details();

            //    SqlDataReader reader = command.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        string name = reader.GetString(reader.GetOrdinal("name"));
            //        string duration = reader.GetString(reader.GetOrdinal("duration"));
            //        string bestplane = reader.GetString(reader.GetOrdinal("bestplane"));

            //        Details destInfoWindow = new Details(name, duration, bestplane);
            //        destInfoWindow.ShowDialog();
            //    }
            //}
            Pick selectedItem = (Pick)comboBox;
            Details detailsWindow = new Details(selectedDestination);
            detailsWindow.Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            book.Show();
            this.Close();
        }
    }
}
