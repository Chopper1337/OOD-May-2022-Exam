using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOD_May_2022_Exam;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRentIncrease()
        {
            //Arrange
            RentalProperty p1 = new RentalProperty()
            {
                ID = 1,
                Location = "Sligo",
                RentalType = RentalType.House,
                Price = 1000m
            };
            decimal expectedPrice = 1500;

            //Act
            p1.IncreaseRent(50);

            //Assert
            Assert.AreEqual(p1.Price, expectedPrice);
        }
    }
}