using CarNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        Car test_car;
        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50);
        }

        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void TestInitialGasTank()
        {
            //Car test_car = new Car("Toyota", "Prius", 10, 50);
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestGasTankLevelAfterDriving()
        {
            //Car test_car = new Car("Toyota", "Prius", 10, 50);
            test_car.Drive(100);
            Assert.AreEqual(8, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestGasTankLevelAfterAttemptingToDriveTooFar() 
        {
            test_car.Drive(10000);
            Assert.AreEqual(0, test_car.GasTankLevel, .001);
        }

        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            test_car.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
        }
    }
}
