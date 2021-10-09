using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using NUnit.Framework;

namespace UnitTests.Model
{
    /// <summary>
    /// Тестовый набор для класса HelicopterTransport.
    /// </summary>
    [TestFixture]
    public class HelicopterTransportTest
    {
        /// <summary>
        /// Тестирование свойства TransportName.
        /// </summary>
        [Test(Description = "Тестирование свойства TransportName")]
        [TestCase(TestName = "Тестирование свойства TransportName")]
        public void TestName()
        {
            Assert.AreEqual("Вертолёт", 
                new Helicopter(5, 8).TransportName);
            Assert.AreNotEqual("вертолёт", 
                new Helicopter(8, 2).TransportName);
            Assert.AreNotEqual("Вертушка", 
                new Helicopter(6, 18).TransportName);
            Assert.AreNotEqual("акула", 
                new Helicopter(14, 12).TransportName);
            Assert.AreNotEqual(" Вертолёт", 
                new Helicopter(11, 200).TransportName);
        }

        /// <summary>
        /// Тестирование свойства ConsumedFuel
        /// (положительное тестирование).
        /// </summary>
        /// <param name="timeFligth">Время полёта.</param>
        /// <param name="fuelConsumption">Расход топлива.</param>
        [Test]
        [TestCase(AbstractTransport.minParametrValue + 0.1,
            AbstractTransport.minParametrValue + 0.1,
            TestName = "Tест количества затраченного топлива" +
            " при минимально допустимых параметрах.")]
        [TestCase(AbstractTransport.minParametrValue + 1,
            AbstractTransport.minParametrValue + 1,
            TestName = "Tест количества затраченного топлива" +
            " при минимально допустимых параметрах +1.")]
        [TestCase(80, 90, TestName = "Tест количества " +
            "затраченного топлива.")]
        [TestCase(Helicopter.maxTimeFligth - 1,
            Helicopter.maxConsumedConsumption - 1, 
            TestName = "Tест количества затраченного" +
            " топлива при максимально допустимых параметрах -1.")]
        [TestCase(Helicopter.maxTimeFligth - 0.001,
            Helicopter.maxConsumedConsumption - 0.001,
            TestName = "Tест количества затраченного" +
            " топлива при максимально допустимых параметрах.")]
        public void TestPosetivSpendFuel(double timeFligth,
            double fuelConsumption)
        {
            Helicopter auto = new Helicopter(timeFligth,
                fuelConsumption);
            Assert.True(auto.ConsumedFuel ==
                (timeFligth * fuelConsumption));
            Assert.AreEqual(timeFligth, fuelConsumption,
                timeFligth * fuelConsumption);
        }

        /// <summary>
        /// Тестирование свойства ConsumedFuel
        /// (негативное тестирование).
        /// </summary>
        /// <param name="timeFligth">Время полёта.</param>
        /// <param name="fuelConsumption">Расход топлива.</param>
        [Test]
        [TestCase(Helicopter.minParametrValue, 1,
            TestName = "Tест затраченного топлива " +
            "(при недопустимом (малом) значении времени полёта).")]
        [TestCase(1, Helicopter.minParametrValue,
            TestName = "Tест затраченного топлива " +
            "(при недопустимом (малом) значении расхода).")]
        [TestCase(Helicopter.minParametrValue - 1,
            Helicopter.minParametrValue - 1,
            TestName = "Tест затраченного топлива " +
            "(при отрицательных значениях).")]
        [TestCase(Helicopter.maxTimeFligth + 1, 10,
            TestName = "Tест затраченного топлива" +
            " (при недопустимом (большом) значении времени полёта).")]
        [TestCase(10, Helicopter.maxConsumedConsumption+1,
            TestName = "Tест затраченного топлива" +
            " (при недопустимом (большом) значении расхода).")]
        public void TestNegotiveSpendFuel(double timeFligth,
            double fuelConsumption)
        {
            Assert.Throws<Exception>(delegate ()
            {
                Helicopter auto = new Helicopter(timeFligth,
                    fuelConsumption);
            });
        }
    }
}