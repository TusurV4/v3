using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для описания параметров вертолёта.
    /// </summary>
    public class Helicopter : AbstractTransport
    {
        /// <summary>
        /// Конструктор класса Helicopter.
        /// </summary>
        /// <param name="timeFligth">Время полёта.</param>
        /// <param name="fuelConsumption">Расход топлива.</param>
        public Helicopter(double timeFligth, double fuelConsumption)
        {
            TimeFligth = timeFligth;
            FuelConsumption = fuelConsumption;
        }

        /// <summary>
        /// Константа для описания максимального времени полёта.
        /// </summary>
        public const int maxTimeFligth = 10000;

        /// <summary>
        /// Поле для описания времени полёта.
        /// </summary>
        private double _timeFligth;

        /// <summary>
        /// Свойство для описания времени полёта.
        /// </summary>
        private protected double TimeFligth
        {
            get => _timeFligth;
            set => _timeFligth = CheckInput("время полёта",
                value, minParametrValue, maxTimeFligth);
        }

        /// <summary>
        /// Свойство для описания названия транспортного средства.
        /// </summary>
        public override string TransportName => "Вертолёт";

        /// <summary>
        /// Свойство для описания количества затраченного топлива.
        /// </summary>
        public override double ConsumedFuel =>
            FuelConsumption * TimeFligth;
    }
}
