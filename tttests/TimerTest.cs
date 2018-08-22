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
            Timer.Instance.Start();
            Timer.Instance.Stop();
            Assert.AreEqual(0, Timer.Instance.Value);
        }
        [TestMethod]
        public void Run_Half_Seconds()
        {
            Timer.Instance.Start();
            System.Threading.Thread.Sleep(500);
            Timer.Instance.Stop();
            Assert.AreEqual(0, Timer.Instance.Value);
        }
        [TestMethod]
        public void Run_One_Seconds()
        {
            Timer.Instance.Start();
            System.Threading.Thread.Sleep(1020); // timer needs a bit more miliseconds to trigger +1
            Timer.Instance.Stop();
            Assert.AreEqual(1, Timer.Instance.Value);
        }

        [TestMethod]
        public void CheckFormatting_100()
        {
            MyAssert.Equals("00:01:40", Timer.FormatTime(100));
        }

        [TestMethod]
        public void CheckFormatting_3600()
        {
            MyAssert.Equals("01:00:00", Timer.FormatTime(3600));
        }

        [TestMethod]
        public void CheckFormatting_86400()
        {
            MyAssert.Equals("24:00:00", Timer.FormatTime(86400));
        }

        [TestMethod]
        public void CheckFormatting_0()
        {
            MyAssert.Equals("00:00:00", Timer.FormatTime(0));
        }
    }
}
