using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherHandler
{
    struct WeatherMeasurements
    {
        public float temperature;
        public float humidity;
        public float pressure;
    }
    class WeatherData
    {
        private WeatherMeasurements weatherMeasurements = new WeatherMeasurements();
        public delegate void ChangeHandler(object sender, WeatherMeasurements newWeatherMeasurements);
        public event ChangeHandler ChangeEvent;

        public void Change()
        {
            Notify();
        }

        public void UpdateReadings(WeatherMeasurements weather)
        {
            this.weatherMeasurements = weather;
            Change();
        }

        private void Notify()
        {
            if(ChangeEvent != null)
            {
                ChangeEvent(this, this.weatherMeasurements);
            }
        }
    }
}
