using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp_Assignment2;

namespace UnitTestVehicleRentalSystem
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class JourneyTests
    {
        Journey j = new Journey();

        [TestMethod]
        public void TestConstructor()
        {
            Assert.IsNotNull(j);
        }

        [TestMethod]
        public void TestGetKilometers()
        {
            double expectedKm = 0;
            double actualKm = j.getKilometers();
            Assert.AreEqual(expectedKm, actualKm);
        }

        [TestMethod]
        public void TestAddKilometers()
        {
            j.addKilometers(1.23);
            double expectedKm = 1.23;
            double actualKm = j.getKilometers();
            Assert.AreEqual(expectedKm, actualKm);
        }

        [TestMethod]
        public void TestAddKilometersTwice()
        {
            j.addKilometers(1.23);
            j.addKilometers(4.56);
            double expectedKm = 1.23+4.56;
            double actualKm = j.getKilometers();
            Assert.AreEqual(expectedKm, actualKm);
        }

        [TestMethod]
        public void TestAddZeroKilometers()
        {
            bool gaveError = false;
            try
            {
                j.addKilometers(0);
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
        public void TestAddNegativeKilometers()
        {
            bool gaveError = false;
            try
            {
                j.addKilometers(-697);
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
