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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\t.hinkov23\Source\Repos\HinkovT_FinalPr_Sem2\HinkovT_FinalPr_Sem2\FinalSem2.mdf;Integrated Security=True");
            try
            {
                sqlCon.Open();
                string query = "INSERT INTO SignUp (firstname, lastname, username, email, password) values('" + this.txtFirst_name.Text + "','" + this.txtLast_name.Text + "','" + this.txtUsername.Text + "','" + this.txtEmail.Text + "','" + this.PasswordBox.Password + "')";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.ExecuteNonQuery();
                Book book = new Book();
                book.Show();
                this.Close();
            }
            finally
            {
                sqlCon.Close();
            }
            
            
        }
    }
}
