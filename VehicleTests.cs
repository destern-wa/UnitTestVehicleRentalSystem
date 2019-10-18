using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp_Assignment2;

namespace UnitTestVehicleRentalSystem
{
    /// <summary>
    /// Summary description for VehicleTests
    /// </summary>
    [TestClass]
    public class VehicleTests
    {


        [TestMethod]
        public void TestNormalConstructor()
        {
            bool gaveError = false;
            try
            {
                Vehicle v = new Vehicle("man", "mod", 3000);
            }
            catch
            {
                gaveError = true;
            }
            finally
            {
                Assert.IsFalse(gaveError);
            }
        }

        [TestMethod]
        public void TestEmptyManufacturerConstructor()
        {
            bool gaveError = false;
            try
            {
                Vehicle v = new Vehicle("", "mod", 3000);
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
        public void TestEmptyModelConstructor()
        {
            bool gaveError = false;
            try
            {
                Vehicle v = new Vehicle("man", "", 3000);
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
        public void TestBadMakeYearConstructor()
        {
            bool gaveError = false;
            try
            {
                Vehicle v = new Vehicle("man", "mod", 1776);
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
        public void TestFutureMakeYearConstructor()
        {
            bool gaveError = false;
            int currentYear = (new DateTime()).Year;
            try
            {
                Vehicle v = new Vehicle("man", "mod", currentYear+1);
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
