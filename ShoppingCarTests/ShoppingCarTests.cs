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
        public void PaytheBillTest_Buy_V1_Book()
        {
            //arrange
            CShoppingCar target = new CShoppingCar("HarryPotter");
            target.SetTheGoodsNumber(1, 0, 0, 0, 0);
            double actual = new double();
            int expected = 100;
            
            //act
            actual = target.PayTheBill();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PaytheBillTest_Buy_V1_V2_Book()
        {
            //arrange
            CShoppingCar target = new CShoppingCar("HarryPotter");
            target.SetTheGoodsNumber(1, 1, 0, 0, 0);
            double actual = new double();
            int expected = 190;

            //act
            actual = target.PayTheBill();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PaytheBillTest_Buy_V1_V2_V3_Book()
        {
            //arrange
            CShoppingCar target = new CShoppingCar("HarryPotter");
            target.SetTheGoodsNumber(1, 1, 1, 0, 0);
            double actual = new double();
            int expected = 270;

            //act
            actual = target.PayTheBill();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PaytheBillTest_Buy_V1_V2_V3_V4_Book()
        {
            //arrange
            CShoppingCar target = new CShoppingCar("HarryPotter");
            target.SetTheGoodsNumber(1, 1, 1, 1, 0);
            double actual = new double();
            int expected = 320;

            //act
            actual = target.PayTheBill();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PaytheBillTest_Buy_V1_V2_V3_V4_V5_Book()
        {
            //arrange
            CShoppingCar target = new CShoppingCar("HarryPotter");
            target.SetTheGoodsNumber(1, 1, 1, 1, 1);
            double actual = new double();
            int expected = 375;

            //act
            actual = target.PayTheBill();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PaytheBillTest_Buy_V1_V2_V3x2_Book()
        {
            //arrange
            CShoppingCar target = new CShoppingCar("HarryPotter");
            target.SetTheGoodsNumber(1, 1, 2, 0, 0);
            double actual = new double();
            int expected = 370;

            //act
            actual = target.PayTheBill();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PaytheBillTest_Buy_V1_V2x2_V3x2_Book()
        {
            //arrange
            CShoppingCar target = new CShoppingCar("HarryPotter");
            target.SetTheGoodsNumber(1, 2, 2, 0, 0);
            double actual = new double();
            int expected = 460;

            //act
            actual = target.PayTheBill();

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
