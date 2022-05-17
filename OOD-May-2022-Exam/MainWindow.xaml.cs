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
using System.Data.Entity;

namespace OOD_May_2022_Exam
{
    /// <summary>
    /// Github link: https://github.com/Chopper1337/OOD-May-2022-Exam
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<RentalProperty> properties;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Event for when Add button is clicked
        private void AddBTN(object sender, RoutedEventArgs e)
        {
            //Create a local instance of the AddWindow window
            AddWindow addWindow = new AddWindow();
            //Show this instance of the window
            addWindow.Show();
        }

        //Update the description box based on the selected index in listbox
        private void PropertiesSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selection = PropertiesLB.SelectedIndex + 1;
            RentalPropertyData db = new RentalPropertyData();
            var q = from x in db.Properties
                    where x.ID == selection
                    select new
                    {
                        Description = x.Description,
                    };

            PropertyDescriptionTBLK.Text = q.ToList()[0].Description;
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            RentalPropertyData db = new RentalPropertyData();
            var q = from x in db.Properties
                    orderby x.ID
                    select x;

            properties = q.ToList();

            PropertiesLB.ItemsSource = properties;
        }
    }
}
