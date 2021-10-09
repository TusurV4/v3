using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для описания параметров машины.
    /// </summary>
    public class Automobile : AbstractTransport
    {
        /// <summary>
        /// Конструктор класса Automobile.
        /// </summary>
        /// <param name="coveredDistance">Преодолённое расстояние.</param>
        /// <param name="fuelConsumption">Расход топлива.</param>
        public Automobile(double coveredDistance, double fuelConsumption)
        {
            CoveredDistance = coveredDistance;
            FuelConsumption = fuelConsumption;
        }

        /// <summary>
        /// Константа для описания максимального преодолённого расстояния.
        /// </summary>
        public const int maxCoveredDistance = 100000;

        /// <summary>
        /// Поле для описания преодолённого расстояния.
        /// </summary>
        private double _coveredDistance;

        /// <summary>
        /// Свойство для описания преодолённого расстояния.
        /// </summary>
        private protected double CoveredDistance
        {
            get => _coveredDistance;
            set => _coveredDistance = CheckInput("преодолённое расстояние",
                value, minParametrValue, maxCoveredDistance);
        }

        /// <summary>
        /// Свойство для описания названия транспортного средства.
        /// </summary>
        public override string TransportName => "Машина";

        /// <summary>
        /// Свойство для описания количества затраченного топлива.
        /// </summary>
        public override double ConsumedFuel => 
            FuelConsumption * CoveredDistance;
    }
}