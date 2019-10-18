using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp_Assignment2;

namespace UnitTestVehicleRentalSystem
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [TestClass]
    public class ServiceTests
    {
        Service s = new Service();

        [TestMethod]
        public void TestConstructor()
        {
            Assert.IsNotNull(s);
        }

        [TestMethod]
        public void TestGetLastServiceOdometerKm()
        {
            double expectedKm = 0;
            double actualKm = s.getLastServiceOdometerKm();
            Assert.AreEqual(expectedKm, actualKm);
        }

        [TestMethod]
        public void TestRecordService()
        {
            s.recordService(321);

            double expectedKm = 321;
            double actualKm = s.getLastServiceOdometerKm();
            Assert.AreEqual(expectedKm, actualKm);

            double expectedServiceCount = 1;
            double actualServices = s.getServiceCount();
            Assert.AreEqual(expectedServiceCount, actualServices);

        }

        [TestMethod]
        public void TestGetTotalScheduledServices()
        {
            // Initial
            int num = s.getTotalScheduledServices();
            Assert.AreEqual(0, num);

            // Still not due for service (last service under 10,000)
            s.recordService(100);
            int num1 = s.getTotalScheduledServices();
            Assert.AreEqual(0, num1);


            // Due for one service  (last service over 10,000, under 20,000)
            s.recordService(10010);
            int num2 = s.getTotalScheduledServices();
            Assert.AreEqual(1, num2);

            // Due for two services  (last service over 20,000, under 30,000)
            s.recordService(20020);
            int num3 = s.getTotalScheduledServices();
            Assert.AreEqual(2, num3);
        }
    }
}
