using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WPF_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(true, true);
        }
    }
}
