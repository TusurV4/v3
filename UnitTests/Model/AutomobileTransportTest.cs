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
    /// Тестовый набор для класса AutomobileTransport.
    /// </summary>
    [TestFixture]
    public class AutomobileTransportTest
    {
        /// <summary>
        /// Тестирование свойства TransportName.
        /// </summary>
        [Test(Description = "Тестирование свойства TransportName")]
        [TestCase(TestName = "Тестирование свойства TransportName")]
        public void TestName()
        {
            Assert.AreEqual("Машина",
                new Automobile(8, 6).TransportName);

            Assert.AreNotEqual("машина",
                new Automobile(7, 3).TransportName);

            Assert.AreNotEqual("Автомобиль",
                new Automobile(15, 20).TransportName);

            Assert.AreNotEqual("Тачка",
                new Automobile(15, 2).TransportName);

            Assert.AreNotEqual("Вспыш",
                new Automobile(55, 200).TransportName);
        }

        /// <summary>
        /// Тестирование свойства ConsumedFuel(положительное тестирование).
        /// </summary>
        /// <param name = "coveredDistance" > Преодолённое
        /// расстояние.</param>
        /// <param name = "fuelConsumption" > Расход топлива.</param>
        [Test]
        [TestCase(AbstractTransport.minParametrValue + 0.1,
            AbstractTransport.minParametrValue + 0.1,
            TestName = "Tест количества затраченного топлива " +
            "при минимально допустимых параметрах.")]

        [TestCase(AbstractTransport.minParametrValue + 1,
            AbstractTransport.minParametrValue + 1,
            TestName = "Tест количества затраченного топлива " +
            "при минимально допустимых параметрах +1.")]

        [TestCase(82, 116,
            TestName = "Tест количества затраченного топлива.")]

        [TestCase(Automobile.maxCoveredDistance - 1,
            AbstractTransport.maxConsumedConsumption - 1,
            TestName = "Tест количества затраченного " +
            "топлива при максимально допустимых параметрах -1.")]

        [TestCase(Automobile.maxCoveredDistance - 0.0001
            , AbstractTransport.maxConsumedConsumption - 0.0001,
            TestName = "Tест количества затраченного " +
            "топлива при максимально допустимых параметрах.")]

        public void TestPosetivConsumedFuel(double coveredDistance,
            double fuelConsumption)
        {
            Automobile auto = new Automobile(coveredDistance,
                fuelConsumption);
            Assert.True(auto.ConsumedFuel == (coveredDistance
                * fuelConsumption));
            Assert.AreEqual(coveredDistance, fuelConsumption,
                coveredDistance * fuelConsumption);
        }

        /// <summary>
        /// Тестирование свойства ConsumedFuel
        /// (негативное тестирование).
        /// </summary>
        /// <param name="coveredDistance">Преодолённое
        /// расстояние.</param>
        /// <param name="fuelConsumption">Расход
        /// топлива.</param>
        [Test]
        [TestCase(Automobile.maxCoveredDistance, 1,
            TestName = "Tест затраченного топлива" +
            " (при недопустимом (малом) значении расстояния).")]

        [TestCase(1, AbstractTransport.minParametrValue,
            TestName = "Tест затраченного топлива" +
            " (при недопустимом (малом) значении расхода).")]

        [TestCase(-1, -1, TestName = "Tест затраченного топлива" +
            " (при отрицательных значениях).")]

        [TestCase(Automobile.maxCoveredDistance + 1, 1,
            TestName = "Tест затраченного топлива" +
            " (при недопустимом (большом) значении расстояния).")]

        [TestCase(1, Automobile.maxConsumedConsumption + 1,
            TestName = "Tест затраченного топлива" +
            " (при недопустимом (большом) значении расхода).")]

        public void TestNegotiveConsumedFuel(double coveredDistance,
            double fuelConsumption)
        {
            Assert.Throws<Exception>(delegate ()
            {
                Automobile auto = new Automobile(coveredDistance,
                    fuelConsumption);
            });
        }
    }
}