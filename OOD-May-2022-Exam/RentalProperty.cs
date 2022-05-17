using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_May_2022_Exam
{
    public class RentalProperty
    {
        public int ID{ get; set; }
        public RentalType RentalType { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public void IncreaseRent(int percentage)
        {
            decimal Increase = Price * percentage;
            Price += Increase;
        }
    }

    public enum RentalType
    {
        House,
        Flat,
        Share
    }

    public class RentalPropertyData : DbContext
    {
        public RentalPropertyData() : base("MyRentalPropertyData") { }

        public DbSet<RentalProperty> Properties {get; set;}
    }
}
