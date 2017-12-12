using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MeowApp;

namespace MeowTest
{
    [TestClass]
    public class MeowTest
    {
        [TestMethod]
        public void TestMeowCount()
        {
            string test = "I meow cat. Meow \n meow cat";
            int result = MeowApp.Models.MeowModel.MeowCount(test);
            Assert.AreEqual(3, result);
        }
    }
}
