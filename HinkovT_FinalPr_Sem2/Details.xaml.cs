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
        public Details(Details selectedDestination)
        {
            InitializeComponent();

            DataContext = new DestinationDetailsViewModel(selectedDestination);
        }

        public Details(Pick selectedDestination)
        {
        }

        public class DestinationDetailsViewModel
        {
            private object selectedDestination1;
            private Details selectedDestination;

            public Pick SelectedDestination { get; set; }

            public DestinationDetailsViewModel(Pick selectedDestination)
            {
                SelectedDestination = selectedDestination;
            }

            public DestinationDetailsViewModel(Pick selectedDestination, object selectedDestination1) : this(selectedDestination)
            {
                this.selectedDestination1 = selectedDestination1;
            }

            public DestinationDetailsViewModel(Details selectedDestination)
            {
                this.selectedDestination = selectedDestination;
            }
        }
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
    //public class DetailsInfo
    //{
    //    public string Duration { get; set; }
    //    public string Bestplane { get; set; }
    //    public string Name { get; set; }


    //    public DetailsInfo(string duration, string bestplane, string name)
    //    {
    //        Duration = duration;
    //        Bestplane = bestplane;
    //        Name = name;

    //    }
    //}
}
