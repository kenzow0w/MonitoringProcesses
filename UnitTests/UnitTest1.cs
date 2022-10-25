using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using WindowsFormMonitoring;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        Monitor monitor = new Monitor();
        [TestMethod]
        public void TestInputValuesInForm()
        {
            string emptyText = "";
            int time0 = 0;
            string text = "notepad";
            int time5 = 5;
            Assert.IsTrue(monitor.getMaxTimeProcessFromForm(time0) == 0);
            Assert.IsTrue(monitor.getMonitoringFrequnceFromForm(time0) == 0);
            Assert.IsTrue(monitor.getProcessNameFromForm(emptyText) == null);
            Assert.IsTrue(monitor.getMaxTimeProcessFromForm(time5) == 5);
            Assert.IsTrue(monitor.getMonitoringFrequnceFromForm(time5) == 5);
            Assert.IsTrue(monitor.getProcessNameFromForm(text).Equals(text));
            
        }

        [TestMethod]
        public void TestFindProcessByName()
        {
            String expectedText = "";
            Process p = monitor.findProcessByName(expectedText);

            Assert.IsTrue(p == null);

            String expectedText2 = "svchost";
            Process p2 = monitor.findProcessByName(expectedText2);

            Assert.IsTrue(p2.ProcessName.ToString().Equals(expectedText2));
        }
    }
}
