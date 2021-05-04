using Microsoft.VisualStudio.TestTools.UnitTesting;
using MotarCycle_RacingAssign;
using System;

namespace MotarCycle_RacingAssignTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bike bk = new Bike();
            if (bk.endPoint() == 800)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }

        }
        [TestMethod]
        public void TestMethod2()
        {
            Bike bk = new Bike();
            if (bk.strtPoint() == 0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

        }

    }
}
