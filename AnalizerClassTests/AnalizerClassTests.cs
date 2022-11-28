using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AnalizerClassLibrary.Tests
{
    [TestClass]
    public class AnalizerClassTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "data.xml", "ValidData", DataAccessMethod.Sequential)]
        public void IsOperator_WhenIncomingDataIsValid_ReturnsTrue()
        {
            //Arrange
            bool expected = Convert.ToBoolean(TestContext.DataRow["expected"]);
            string initial = Convert.ToString(TestContext.DataRow["incomingData"]);
            //Actual
            bool actualResult = AnalizerClass.IsOperator(initial);
            //Assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "data.xml", "InValidData", DataAccessMethod.Sequential)]
        public void IsOperator_WhenIncomingDataIsValid_ReturnsFalse()
        {
            //Arrange
            bool expected = Convert.ToBoolean(TestContext.DataRow["expected"]);
            string initial = Convert.ToString(TestContext.DataRow["incomingData"]);
            //Actual
            bool actualResult = AnalizerClass.IsOperator(initial);
            //Assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "data.xml", "ValidData2", DataAccessMethod.Sequential)]
        public void InsertedSymbol_WhenIncomingDataIsValid()
        {
            //Arrange
            string expected = Convert.ToString(TestContext.DataRow["expected"]);
            string initial = Convert.ToString(TestContext.DataRow["incomingData"]);
            //Actual
            string actualResult = AnalizerClass.InsertSymbol(initial, '/', 1);
            //Assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "data.xml", "InValidData2", DataAccessMethod.Sequential)]
        public void InsertedSymbol_WhenIncomingDataIsInValid()
        {
            //Arrange
            string expected = Convert.ToString(TestContext.DataRow["expected"]);
            string initial = Convert.ToString(TestContext.DataRow["incomingData"]);
            //Actual
            string actualResult = AnalizerClass.InsertSymbol(initial, '+', 2);
            //Assert
            Assert.AreEqual(expected, actualResult);
        }
    }
}
