using System;

namespace Observer
{
    public class StatisticsDisplay : Observer, DisplayElement
    {
        private float maxTemp;
        private float minTemp;
        private float tempSum;

        private int numReadings;
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            this.maxTemp = 0.0f;
            this.minTemp = 2000.0f;
            this.tempSum = 0.0f;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            tempSum += temperature;
            numReadings++;

            if (temperature > maxTemp)
            {
                maxTemp = temperature;
            }

            if (temperature < minTemp)
            {
                minTemp = temperature;
            }

            display();
        }
        public void display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings)
            + "/" + maxTemp + "/" + minTemp);
        }
    }
}