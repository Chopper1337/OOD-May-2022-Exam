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
using System.Data.Entity;

namespace OOD_May_2022_Exam
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void SaveBTN(object sender, RoutedEventArgs e)
        {
            if (ValidateData())
            {
                RentalPropertyData db = new RentalPropertyData();
                RentalProperty newProperty = new RentalProperty();
                newProperty.RentalType = (RentalType)(RentalTypeCBX.SelectedValue);
                newProperty.Location = LocationTBLK.Text;
                newProperty.Price = int.Parse(PriceTBLK.Text);
                newProperty.Description = DescriptionTBLK.Text;
                db.Properties.Add(newProperty);
                db.SaveChanges();
                MessageBox.Show("Item added.");
                this.Close();
            }
        }

        //Checks if all the expected inputs fields contain what they're supposed to
        bool ValidateData()
        {
            if(RentalTypeCBX.SelectedItem is null)
                return false;

            if(LocationTBLK.Text.Length < 1)
                return false;

            if(PriceTBLK.Text.Length < 1)
                return false;

            if(DescriptionTBLK.Text.Length < 1)
                return false;

            return true;
        }
    }
}
