using System;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WeatherData weatherData = new WeatherData();
            CurrentConditionDisplay conditionDisplay = new CurrentConditionDisplay(weatherData);
            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);

        }
    }
}
