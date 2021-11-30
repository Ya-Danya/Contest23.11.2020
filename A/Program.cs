using System;

namespace A
{


    public static class TemperatureCalculator
    {
        public static double FromCelsiusToFahrenheit(double celsiusTemperature)
        {
            if (celsiusTemperature < -273.15)
            {
                throw new ArgumentException("Incorrect input");
            }
            double Fahrenheit = celsiusTemperature * 1.8 + 32;
            return Fahrenheit;
        }

        public static double FromCelsiusToKelvin(double celsiusTemperature)
        {
            if (celsiusTemperature < -273.15)
            {
                throw new ArgumentException("Incorrect input");
            }
            double Kelvin = celsiusTemperature + 273.15;
            return Kelvin;
        }

        public static double FromFahrenheitToCelsius(double fahrenheitTemperature)
        {
            if (fahrenheitTemperature < -459.67)
            {
                throw new ArgumentException("Incorrect input");
            }

            double Celsius = (fahrenheitTemperature - 32) / 1.8;
            return Celsius;
        }

        public static double FromFahrenheitToKelvin(double fahrenheitTemperature)
        {
            if (fahrenheitTemperature < -459.67)
            {
                throw new ArgumentException("Incorrect input");
            }
            double Kelvin = (fahrenheitTemperature - 32) / 1.8 + 273.15;
            return Kelvin;
        }

        public static double FromKelvinToCelsius(double kelvinTemperature)
        {
            if (kelvinTemperature < 0)
            {
                throw new ArgumentException("Incorrect input");
            }

            double Celsius = kelvinTemperature - 273.15;
            return Celsius;
        }

        public static double FromKelvinToFahrenheit(double kelvinTemperature)
        {
            if (kelvinTemperature < 0)
            {
                throw new ArgumentException("Incorrect input");
            }
            double Fahrenheit = (kelvinTemperature - 273.15) * 1.8 + 32;
            return Fahrenheit;
        }
    

        static void Main(string[] args)
        {
            string[] temperatureParams = Console.ReadLine().Split(' ');
            string temperatureType = temperatureParams[0];
            double startTemperatureValue = double.Parse(temperatureParams[1]);
            try
            {
                switch (temperatureType)
                {
                    case "C":
                        Console.WriteLine(TemperatureCalculator.FromCelsiusToFahrenheit(startTemperatureValue));
                        Console.WriteLine(TemperatureCalculator.FromCelsiusToKelvin(startTemperatureValue));
                        break;
                    case "F":
                        Console.WriteLine(TemperatureCalculator.FromFahrenheitToCelsius(startTemperatureValue));
                        Console.WriteLine(TemperatureCalculator.FromFahrenheitToKelvin(startTemperatureValue));
                        break;
                    case "K":
                        Console.WriteLine(TemperatureCalculator.FromKelvinToCelsius(startTemperatureValue));
                        Console.WriteLine(TemperatureCalculator.FromKelvinToFahrenheit(startTemperatureValue));
                        break;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
