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
    /// Тестовый набор для класса HybridTransport.
    /// </summary>
    [TestFixture]
    public class HybridTransportTest
    {
        /// <summary>
        /// Тестирование свойства TransportName.
        /// </summary>
        [Test(Description = "Тестирование свойства TransportName")]
        [TestCase(TestName = "Тестирование свойства TransportName")]
        public void TestName()
        {
            Assert.AreEqual("Машина-гибрид", new HybridCar(99, 45, 6)
                .TransportName);

            Assert.AreNotEqual("машина-гибрид",
                new HybridCar(100, 50, 7).TransportName);

            Assert.AreNotEqual(" Машина-гибрид", new HybridCar(88, 11, 3)
                .TransportName);

            Assert.AreNotEqual("Машина-гибрид ", new HybridCar(54, 34, 7)
                .TransportName);

            Assert.AreNotEqual("м_ашина-гибрид", new HybridCar(40, 20, 55)
                .TransportName);
        }

        /// <summary>
        /// Тестирование свойства ConsumedFuel
        /// (положительное тестирование).
        /// </summary>
        /// <param name="totalCoveredDistance">Общее преодолённое
        /// расстояние.</param>
        /// <param name="coveredDistanceElectricMotor">Преодолённое 
        /// расстояние на электродвигателе.</param>
        /// <param name="fuelConsumption">Расход топлива.</param>
        [Test]
        [TestCase(HybridCar.minParametrValue + 0.001,
            HybridCar.minParametrValue + 0.001,
            HybridCar.minParametrValue + 0.001,
            TestName = "Tест количества затраченного " +
            "топлива при минимально допустимых параметрах.")]

        [TestCase(HybridCar.minParametrValue + 1,
            HybridCar.minParametrValue + 1,
            HybridCar.minParametrValue + 1,
            TestName = "Tест количества затраченного " +
            "топлива при минимально допустимых параметрах +1.")]

        [TestCase(81, 80, 79,
            TestName = "Tест количества затраченного топлива.")]

        [TestCase(HybridCar.maxTotalCoveredDistance - 0.001,
            HybridCar.maxCoreredDistanceElectricMotor - 0.001,
            HybridCar.maxConsumedConsumption - 0.001,
            TestName = "Tест количества затраченного" +
            " топлива при максимально допустимых параметрах.")]

        [TestCase(HybridCar.maxTotalCoveredDistance - 1,
            HybridCar.maxCoreredDistanceElectricMotor - 1,
            HybridCar.maxConsumedConsumption - 1,
            TestName = "Tест количества затраченного" +
            " топлива при максимально допустимых параметрах-1.")]

        public void TestPosetivSpendFuel(double totalCoveredDistance,
                double coveredDistanceElectricMotor,
                double fuelConsumption)
        {
            HybridCar hybridCar = new HybridCar(totalCoveredDistance,
                coveredDistanceElectricMotor, fuelConsumption);
            Assert.True(hybridCar.ConsumedFuel == ((totalCoveredDistance
                - coveredDistanceElectricMotor) * fuelConsumption));
        }

        /// <summary>
        /// Тестирование свойства ConsumedFuel
        ///(негативное тестирование).
        /// </summary>
        /// <param name="totalCoveredDistance">Общее преодолённое
        /// расстояние.</param>
        /// <param name="coreredDistanceElectricMotor">Преодолённое 
        /// расстояние на электродвигателе.</param>
        /// <param name="fuelConsumption">Расход топлива.</param>
        [Test]
        [TestCase(HybridCar.minParametrValue - 1,
            HybridCar.minParametrValue + 1,
            HybridCar.minParametrValue + 1,
            TestName = "Tест затраченного топлива (при недопустимом" +
            " (малом) значении общего расстояния).")]

        [TestCase(HybridCar.minParametrValue + 1,
            HybridCar.minParametrValue - 1,
            HybridCar.minParametrValue + 1,
            TestName = "Tест затраченного топлива (при недопустимом" +
            " (малом) значении расстояния на электричестве).")]

        [TestCase(HybridCar.minParametrValue + 1,
            HybridCar.minParametrValue + 1,
            HybridCar.minParametrValue - 1,
            TestName = "Tест затраченного топлива (при недопустимом" +
            " (малом) значении расхода).")]

        [TestCase(HybridCar.minParametrValue - 1,
            HybridCar.minParametrValue - 1,
            HybridCar.minParametrValue - 1,
            TestName = "Tест затраченного топлива (при" +
            " отрицательных значениях).")]

        [TestCase(HybridCar.maxTotalCoveredDistance + 1, 5, 5,
            TestName = "Tест затраченного топлива (при недопустимом" +
            " (большом) значении общего расстояния).")]

        [TestCase(82, HybridCar.maxCoreredDistanceElectricMotor + 1, 6,
            TestName = "Tест затраченного топлива " +
            "(при недопустимом (большом) расстоянии на электричестве).")]

        [TestCase(42, 16, HybridCar.maxConsumedConsumption + 1,
            TestName = "Tест затраченного топлива (при недопустимом" +
            " (большом) значении расхода).")]

        public void TestNegotiveSpendFuel(double totalCoveredDistance,
            double coreredDistanceElectricMotor, double fuelConsumption)
        {
            Assert.Throws<Exception>(delegate ()
            {
                HybridCar hybrid = new HybridCar(totalCoveredDistance,
                    coreredDistanceElectricMotor, fuelConsumption);
            });
        }
    }
}