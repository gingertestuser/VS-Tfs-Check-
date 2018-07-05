using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_test_App;

namespace WPF_Unit_Tests
{
    [TestClass]
    public class UiTestClass
    {

        [TestMethod]
        public  void TestUi()
        {
            MainWindow mw = new MainWindow();


        ;
            Assert.AreEqual(mw.IsVisible, true);
        }
    }
}
