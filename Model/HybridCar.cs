using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для описания параметров машины-гибрида.
    /// </summary>
    public class HybridCar : AbstractTransport
    {
        /// <summary>
        /// Конструктор класса HybridCar.
        /// </summary>
        /// <param name="totalCoveredDistance">Общее преодолённое
        /// расстояние.</param>
        /// <param name="coreredDistanceElectricMotor">Преодолённое 
        /// расстояние на электродвигателе.</param>
        /// <param name="fuelConsumption">Расход топлива.</param>
        public HybridCar(double totalCoveredDistance,
                double coreredDistanceElectricMotor,
                double fuelConsumption)
        {
            TotalCoveredDistance = totalCoveredDistance;
            CoreredDistanceElectricMotor = coreredDistanceElectricMotor;
            FuelConsumption = fuelConsumption;
        }

        /// <summary>
        /// Константа для описания максимального
        /// общего преодолённого расстояния.
        /// </summary>
        public const int maxTotalCoveredDistance = 10000;

        /// <summary>
        /// Поле для описания общего преодолённого расстояния.
        /// </summary>
        private double _totalGeneralDistance;

        /// <summary>
        /// Свойство для описания общего преодолённого расстояния.
        /// </summary>
        private protected double TotalCoveredDistance
        {
            get => _totalGeneralDistance;
            set => _totalGeneralDistance = CheckInput("общее" +
                " преодолённое расстояние", value,
                minParametrValue, maxTotalCoveredDistance);
        }

        /// <summary>
        /// Константа для описания максимального 
        /// преодолённого расстояния на электродвигателе.
        /// </summary>
        public const int maxCoreredDistanceElectricMotor = 9999;

        /// <summary>
        /// Поле для описания преодолённого 
        /// расстояния на электродвигателе.
        /// </summary>
        private double _coreredDistanceElectricMotor;

        /// <summary>
        /// Свойство для описания преодолённого
        /// расстояния на электродвигателе.
        /// </summary>
        private protected double CoreredDistanceElectricMotor
        {
            get => _coreredDistanceElectricMotor;
            set => _coreredDistanceElectricMotor =
                CheckInput("преодолённое расстояние на" +
                " электрическом двигателе", value, minParametrValue,
                    maxCoreredDistanceElectricMotor);
        }

        /// <summary>
        /// Метод вычисления количества затраченного топлива.
        /// </summary>
        /// <returns>Количество затраченного топлива.</returns>
        private double CalculateFuelConsumption()
        {
            if (TotalCoveredDistance > CoreredDistanceElectricMotor)
                return (TotalCoveredDistance 
                    - CoreredDistanceElectricMotor)
                    * FuelConsumption;
            else
                return 0;
        }

        /// <summary>
        /// Свойство для описания названия транспортного средства.
        /// </summary>
        public override string TransportName => "Машина-гибрид";

        /// <summary>
        /// Свойство для описания количества затраченного топлива.
        /// </summary>
        public override double ConsumedFuel => CalculateFuelConsumption();
    }
}