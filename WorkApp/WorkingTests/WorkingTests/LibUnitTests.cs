using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkingLib;

namespace WorkingTests
{
    /// <summary>
    /// Сводное описание для UnitTest1
    /// </summary>
    [TestClass]
    public class LibUnitTests
    {
        public LibUnitTests()
        {
            //
            // TODO: добавьте здесь логику конструктора
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [TestCategory("Lib")]
        public void Bank_GetAge_currentYearAnd1995_21()
        {
            Human bob = new Human();
            bob.Age = 1995;
            Assert.AreEqual(Bank.GetAge(1995), 21);
        }
        [TestMethod]
        [TestCategory("Lib")]
        public void Bank_GetAge_cuurentYearAndMinus20_2036()
        {
            Assert.AreEqual(Bank.GetAge(-20), 2036);
        }
        [TestMethod]
        [TestCategory("Lib")]
        public void Bank_Billing_21and21()
        {
            Assert.AreEqual(Bank.Billing(21), Math.Sin(21));
        }
        [TestMethod]
        [TestCategory("Lib")]
        [ExpectedException(typeof(ArgumentException), "Age can't be below zero.")]

        public void Human_Age_minus10_Exception()
        {
            Human bob = new Human();
            bob.Age = -10;
        }
        [TestMethod]
        [TestCategory("Lib")]
        public void Human_Age_18_18()
        {
            Human bob = new Human();
            bob.Age = 18;
            Assert.AreEqual(bob.Age, 18);
        }
    }
}
