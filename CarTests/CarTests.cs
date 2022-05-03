using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpReflection;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        private const string Expected = "Corvega Atomic V-8\n\nRegistration: h1513-vh41\nYear of Registration: 2072\nCurrently Valued at: 50000\n--------------------------\n";
        [TestMethod]
        public void TestMethod1()
        {
            
           var car = new Car("Corvega", "Atomic V-8", "h1513-vh41", 2072, 50000);
           var result = car.ToString();
           
           Assert.AreEqual(Expected, result);

           Console.WriteLine(car.ToString());
        }
    }
}
