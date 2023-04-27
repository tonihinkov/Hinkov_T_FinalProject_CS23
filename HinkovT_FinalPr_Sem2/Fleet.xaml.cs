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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HinkovT_FinalPr_Sem2
{
    /// <summary>
    /// Interaction logic for Fleet.xaml
    /// </summary>
    public partial class Fleet : Window
    {
        public Fleet()
        {
            InitializeComponent();

            Planes pilatusPC24 = new Planes();
            pilatusPC24.brandModel = "Pilatus PC-24";
            pilatusPC24.crew = "3";
            pilatusPC24.passengers = "6";

            dataGrid.Items.Add(pilatusPC24);

            Planes bombardierChallenger = new Planes();
            bombardierChallenger.brandModel = "Bombardier Challenger 3500";
            bombardierChallenger.crew = "3";
            bombardierChallenger.passengers = "9";

            dataGrid.Items.Add(bombardierChallenger);

            Planes cessna = new Planes();
            cessna.brandModel = "Cessna Citation";
            cessna.crew = "3";
            cessna.passengers = "11";

            dataGrid.Items.Add(cessna);
        }
        public class Planes
        {
            public string brandModel { get; set; }
            public string passengers { get; set; }
            public string crew { get; set; }

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            book.Show();
            this.Close();
        }
    }
}
