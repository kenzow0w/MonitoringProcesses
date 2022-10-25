using NUnit.Framework;
using WindowsFormMonitoring;


namespace TestMonitor
{
    public class MonitorTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestInputFields()
        {
            Assert.Pass();
        }

        [Test]
        public void TestGetProcesses()
        {
            Monitor monitor = new Monitor();
            int maxTime = monitor.getMaxTimeProcess();
            Assert.Pass();
        }
    }
}