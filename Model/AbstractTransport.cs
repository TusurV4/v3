using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Абстрактный класс для описания транспортного средство.
    /// </summary>
    public abstract class AbstractTransport
    {
        /// <summary>
        /// Свойство для описания названия транспортного средства.
        /// </summary>
        public abstract string TransportName { get; }

        /// <summary>
        /// Свойство для описания количества затраченного топлива.
        /// </summary>
        public abstract double ConsumedFuel { get; }

        /// <summary>
        /// Константа для описания минимального значения параметра.
        /// </summary>
        public const int minParametrValue = 0;

        /// <summary>
        /// Константа для описания максимального 
        /// количества затраченного топлива.
        /// </summary>
        public const int maxConsumedConsumption = 500;

        /// <summary>
        /// Поле для описания расхода топлива.
        /// </summary>
        private double _fuelConsumption;

        /// <summary>
        /// Свойство для описания расхода топлива.
        /// </summary>
        private protected double FuelConsumption
        {
            get => _fuelConsumption;
            set => _fuelConsumption = CheckInput("расход топлива",
                value, minParametrValue, maxConsumedConsumption);
        }

        /// <summary>
        /// Метод проверки допустимости введённых значений.
        /// </summary>
        /// <param name="parametrName">Название параметра.</param>
        /// <param name="parametrValue">Значение параметра.</param>
        /// <param name="minParametrValue">Минимальное 
        /// значение параметра.</param>
        /// <param name="maxParametrValue">Максимальное 
        /// значение параметра.</param>
        /// <returns>Результат проверки допустимости ввода.</returns>
        public static double CheckInput(string parametrName,
            double parametrValue, double minParametrValue,
            double maxParametrValue)
        {
            if ((parametrValue > minParametrValue) 
                && (parametrValue < maxParametrValue))
                return parametrValue;
            else
                throw new Exception($"Значение параметра {parametrName}" +
                    $" должно быть больше чем {minParametrValue}" +
                    $" и меньше чем {maxParametrValue}.");
        }
    }
}