using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerStateManagement;
using PowerStateManagement.Settings;
using System;
using System.IO;

namespace PowerStateManagementTests
{
    [TestClass]
    public class PowerStateManagerTests
    {
        private PowerStateManager psm;

        [TestInitialize]
        public void Init()
        {
            psm = new PowerStateManager();
        }

        [TestMethod]
        public void BootUpTimeTest()
        {
            long lastSleepTime = Convert.ToInt64(psm.GetLastSleepTime());
            long lastWakeTime = Convert.ToInt64(psm.GetLastWakeTime());

            Assert.IsTrue(lastSleepTime <= lastWakeTime);
        }

        [TestMethod]
        public void TryGetSystemBatteryStateTest()
        {
            var batteryState = psm.GetSystemBatteryState();
            Assert.IsTrue(!string.IsNullOrEmpty(batteryState));
        }

        [TestMethod]
        public void TryGetSystemPowerInformationTest()
        {
            var powerInfo = psm.GetSystemPowerInformation();
            Assert.IsTrue(!string.IsNullOrEmpty(powerInfo));
        }

        [TestMethod]
        public void ReserveHibernateFileTest()
        {
            psm.ReserveHibernateFile();
            Assert.IsTrue(File.Exists($"c:\\hiberfil.sys"));
        }

        [TestMethod]
        public void DeleteHibernateFileTest()
        {
            psm.DeleteHibernateFile();
            Assert.IsFalse(File.Exists($"c:\\hiberfil.sys"));
        }
    }
}
