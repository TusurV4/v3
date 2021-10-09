using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

using Model;

namespace ConsoleLoader
{
    /// <summary>
    /// Класс для тестирования библиотеки Model.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Статический метод - точка входа в приложение.
        /// </summary>
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");

            CalculateAutomobile();
            CalculateHelicopter();
            CalculateHybrid();

            Console.ReadKey();
        }

        /// <summary>
        /// Статический метод вычисления затраченного топлива машиной.
        /// </summary>
        private static void CalculateAutomobile()
        {
            Console.WriteLine("Машина.");
            double fuelConsumption = EnterFuelConsumption();
            string parametrCoveredDistance = "преодолённое расстояние";
            FillParamert(parametrCoveredDistance,
                Automobile.maxCoveredDistance);
            double coveredDistance = CheckInput(parametrCoveredDistance,
                Automobile.maxCoveredDistance);
            AbstractTransport automobile = 
                new Automobile(coveredDistance, fuelConsumption);
            WriteInformation(automobile);
        }

        /// <summary>
        /// Статический метод вычисления затраченного топлива вертолётом.
        /// </summary>
        private static void CalculateHelicopter()
        {
            Console.WriteLine("Вертолёт.");

            string paramertTimeFligth = "время полёта";
            FillParamert(paramertTimeFligth, Helicopter.maxTimeFligth);
            double timeFligth = CheckInput(paramertTimeFligth,
                Helicopter.maxTimeFligth);
            double fuelConsumption = EnterFuelConsumption();
            AbstractTransport helicopter = new Helicopter(timeFligth,
                fuelConsumption);
            WriteInformation(helicopter);
        }
        /// <summary>
        /// Статический метод вычисления 
        /// затраченного топлива машиной-гибридом.
        /// </summary>
        private static void CalculateHybrid()
        {
            Console.WriteLine("Машина-гибрид.");
            string parametrTotalCoveredDistance = "общее" +
                " преодолённое расстояние";
            FillParamert(parametrTotalCoveredDistance,
                HybridCar.maxTotalCoveredDistance);
            double totalCoveredDistance = 
                CheckInput(parametrTotalCoveredDistance,
                HybridCar.maxTotalCoveredDistance);
            string parametrCoreredDistanceElectricMotor = "преодолённое" +
                " расстояние на электрическом двигателе";
            FillParamert(parametrCoreredDistanceElectricMotor,
                HybridCar.maxCoreredDistanceElectricMotor);
            double electricalDistance = 
                CheckInput(parametrCoreredDistanceElectricMotor,
                HybridCar.maxCoreredDistanceElectricMotor);
            double fuelConsumption = EnterFuelConsumption();
            AbstractTransport hybrid = new HybridCar(totalCoveredDistance,
                electricalDistance, fuelConsumption);
            WriteInformation(hybrid);
        }

        /// <summary>
        /// Статический метод проверки допустимости введённых значений.
        /// </summary>
        /// <param name="parametrName">Название параметра.</param>
        /// <param name="maxParametrValue">Максимальное 
        /// значение параметра.</param>
        private static void FillParamert(string parametrName,
            int maxParametrValue)
        {
            Console.WriteLine($"Введите значение" +
                $" {parametrName}. Значение параметра {parametrName}" +
                $" должно быть больше чем " +
                $"{AbstractTransport.minParametrValue} и" +
                $" меньше чем {maxParametrValue}:");
        }

        /// <summary>
        /// Статический метод для ввода расхода топлива.
        /// </summary>
        /// <returns>Расход топлива.</returns>
        private static double EnterFuelConsumption()
        {
            string parametrFuelConsumption = "расход топлива";
            FillParamert(parametrFuelConsumption,
                AbstractTransport.maxConsumedConsumption);
            double fuelConsumption = CheckInput(parametrFuelConsumption,
                AbstractTransport.maxConsumedConsumption);
            return fuelConsumption;
        }

        /// <summary>
        /// Статический метод проверки лопустимости введённых значений.
        /// </summary>
        /// <param name="paramertName">Название параметра.</param>
        /// <param name="maxParametrValue">Максимальное
        /// значение параметра.</param>
        /// <returns> Результат проверки допустимости.</returns>
        private static double CheckInput(string paramertName,
            int maxParametrValue)
        {
            double value;
            do
            {
                try
                {
                    string parametrValue = Console.ReadLine()
                        .Replace(".", ",");
                    if (parametrValue.Contains(" "))
                    {
                        throw new Exception("Введено некорректное " +
                            "значение.");
                    }
                    value = Convert.ToDouble(parametrValue);
                    AbstractTransport.CheckInput(paramertName, value,
                        AbstractTransport.minParametrValue,
                        maxParametrValue);
                    Console.WriteLine($"Введено значение: {value}.");
                    break;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    FillParamert(paramertName, maxParametrValue);
                }
            } while (true);
            return value;
        }

        /// <summary>
        /// Статический метод вывода информации.
        /// </summary>
        /// <param name="abstractTransport">Объект класса
        /// AbstractTransport</param>
        private static void WriteInformation(AbstractTransport
            abstractTransport)
        {
            Console.WriteLine($"Название транспорта: " +
                $"{abstractTransport.TransportName}");
            Console.WriteLine($"Количество затраченного топлива: " +
                $"{abstractTransport.ConsumedFuel}");
        }
    }
}