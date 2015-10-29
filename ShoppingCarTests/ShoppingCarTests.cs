using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCar.Tests
{
    [TestClass()]
    public class ShoppingCarTests
    {
        [TestMethod()]
        public void PaytheBillTest_Buy_Only_1_Book()
        {
            //arrange
            CShoppingCar target = new CShoppingCar("HarryPotter");
            double actual = new double();
            int expected = 100;
            
            //act
            actual = target.PayTheBill();

            //assert
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }
    }
}
