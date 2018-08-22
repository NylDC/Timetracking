using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using timetracker.Services;

namespace tttests
{
    [TestClass]
    public class TimerTest
    {
        [TestMethod]
        public void Run_Zero_Seconds()
        {
            timetracker.Services.Timer.Instance.Start();
            timetracker.Services.Timer.Instance.Stop();
            Assert.AreEqual(0, timetracker.Services.Timer.Instance.Value);
        }
        [TestMethod]
        public void Run_Half_Seconds()
        {
            timetracker.Services.Timer.Instance.Start();
            Thread.Sleep(500);
            timetracker.Services.Timer.Instance.Stop();
            Assert.AreEqual(0, timetracker.Services.Timer.Instance.Value);
        }
        [TestMethod]
        public void Run_One_Seconds()
        {
            timetracker.Services.Timer.Instance.Start();
            Thread.Sleep(1020); // timer needs a bit more miliseconds to trigger +1
            timetracker.Services.Timer.Instance.Stop();
            Assert.AreEqual(1, timetracker.Services.Timer.Instance.Value);
        }

        [TestMethod]
        public void CheckFormatting_100()
        {
            MyAssert.Equals("00:01:40", timetracker.Services.Timer.FormatTime(100));
        }

        [TestMethod]
        public void CheckFormatting_3600()
        {
            MyAssert.Equals("01:00:00", timetracker.Services.Timer.FormatTime(3600));
        }

        [TestMethod]
        public void CheckFormatting_86400()
        {
            MyAssert.Equals("24:00:00", timetracker.Services.Timer.FormatTime(86400));
        }

        [TestMethod]
        public void CheckFormatting_0()
        {
            MyAssert.Equals("00:00:00", timetracker.Services.Timer.FormatTime(0));
        }
    }
}
