using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChalkovaEM.Srint0.Task4.V0.Lib;
namespace Tyuiu.ChalkovaEM.Srint0.Task4.V0
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckedSubtractionalValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(2, DataService.Devision(10, 5));
        }
    }
}
