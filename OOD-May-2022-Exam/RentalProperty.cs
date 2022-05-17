using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_May_2022_Exam
{
    internal class RentalProperty
    {
        public int ID{ get; set; }
        public RentalType RentalType { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

    public enum RentalType
    {
        House,
        Flat,
        Share
    }
}
