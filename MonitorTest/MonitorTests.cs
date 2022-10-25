using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormMonitoring;

namespace MonitorTest
{
    class MonitorTests
    {
        Monitor monitor = new Monitor();

        [Test]
        public void testGetProcesess()
        {
            monitor.getProcesses();
        }

    }
}
