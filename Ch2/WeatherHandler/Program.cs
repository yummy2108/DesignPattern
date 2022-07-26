using System;

namespace WeatherHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WeatherData weatherData = new WeatherData();

            CurrentConditions currentConditions = new CurrentConditions(weatherData);

            WeatherMeasurements weatherMeasurements = new WeatherMeasurements();
            weatherMeasurements.humidity = 40.5f;
            weatherMeasurements.pressure = 20f;
            weatherMeasurements.temperature = 72f;

            weatherData.UpdateReadings(weatherMeasurements);

            weatherMeasurements.pressure = 10f;
            weatherData.UpdateReadings(weatherMeasurements);

        }
    }
}
