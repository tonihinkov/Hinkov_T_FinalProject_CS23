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
    /// Interaction logic for BankDetails.xaml
    /// </summary>
    public partial class BankDetails : Window
    {
        public BankDetails()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Toni\Source\Repos\HinkovT_FinalPr_Sem2.1\HinkovT_FinalPr_Sem2\DB.mdf; Integrated Security = True");
            try
            {
                sqlCon.Open();
                string query = "INSERT INTO dbo.[BankDetails] (cardnum, name, cvc, expirydate) values('" + this.txtCardNum.Text + "','" + this.txtCardName.Text + "','" + this.txtCVC.Text + "','" + this.txtExpiry.Text + "')";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");

                Book book = new Book();
                book.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
