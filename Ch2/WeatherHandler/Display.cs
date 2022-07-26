using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherHandler
{
    class CurrentConditions : IDisplayElement, IDisposable
    {
        private WeatherData weatherData = null;
        private WeatherMeasurements readings = new WeatherMeasurements();

        public CurrentConditions(WeatherData weather)
        {
            this.weatherData = weather;
            this.weatherData.ChangeEvent += new WeatherData.ChangeHandler(Update);
        }

        public void Update(object subject, WeatherMeasurements newWeatherMeasurements)
        {
            if(subject is WeatherData)
            {
                this.readings = newWeatherMeasurements;
                display();
            }
        }

        public void display()
        {
            Console.WriteLine("Current conditions: {0}F degrees and {1}% humidity.",
                this.readings.temperature, this.readings.humidity);
        }

        public void Dispose()
        {
            this.weatherData.ChangeEvent -= new WeatherData.ChangeHandler(Update);
        }
    }
}
