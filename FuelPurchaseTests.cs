using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp_Assignment2;

namespace UnitTestVehicleRentalSystem
{
    [TestClass]
    public class FuelPurchaseTests
    {
        FuelPurchase fp = new FuelPurchase();

        [TestMethod]
        public void TestConstructor()
        {
            Assert.IsNotNull(fp);
        }

        [TestMethod]
        public void TestSetFuelEconomy()
        {
            double exampleFuelEconomy = 1.01;
            fp.setFuelEconomy(exampleFuelEconomy);

            double actualFuelEconomy = fp.getFuelEconomy();
            Assert.AreEqual(exampleFuelEconomy, actualFuelEconomy);
        }

        [TestMethod]
        public void TestSetFuelEconomyZero()
        {
            bool gaveError = false;
            try
            {
                fp.setFuelEconomy(0);
            }
            catch
            {
                gaveError = true;
            }
            finally
            {
                Assert.IsTrue(gaveError);
            }
        }

        [TestMethod]
        public void TestSetFuelEconomyNegative()
        {
            bool gaveError = false;
            try
            {
                fp.setFuelEconomy(-1.10);
            }
            catch
            {
                gaveError = true;
            }
            finally
            {
                Assert.IsTrue(gaveError);
            }
        }

        [TestMethod]
        public void TestPurchaseFuel()
        {
            fp.purchaseFuel(1.01, 2.02);
            double expectedFuel = 1.01;
            double actualFuel = fp.getFuel();
            Assert.AreEqual(expectedFuel, actualFuel);
        }

        [TestMethod]
        public void TestPurchaseFuelTwice()
        {
            fp.purchaseFuel(1.01, 2.02);
            fp.purchaseFuel(5.55, 2.56);
            double expectedFuel = 1.01+5.55;
            double actualFuel = fp.getFuel();
            Assert.AreEqual(expectedFuel, actualFuel);
        }

        [TestMethod]
        public void TestPurchaseZeroFuel()
        {
            bool gaveError = false;
            try
            {
                fp.purchaseFuel(0, 2.56);
            }
            catch
            {
                gaveError = true;
            }
            finally
            {
                Assert.IsTrue(gaveError);
            }
        }

        [TestMethod]
        public void TestPurchaseNegativeFuel()
        {
            bool gaveError = false;
            try
            {
                fp.purchaseFuel(-6, 2.56);
            }
            catch
            {
                gaveError = true;
            }
            finally
            {
                Assert.IsTrue(gaveError);
            }
        }

        [TestMethod]
        public void TestPurchaseNegativePrice()
        {
            bool gaveError = false;
            try
            {
                fp.purchaseFuel(6, -2.56);
            }
            catch
            {
                gaveError = true;
            }
            finally
            {
                Assert.IsTrue(gaveError);
            }
        }
    }
}
