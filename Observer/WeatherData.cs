using System.Collections;

namespace Observer
{
    public class WeatherData : Subject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;


        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            int index = observers.IndexOf(o);
            if (index > 0)
            {
                observers.RemoveAt(index);
            }
        }

        public void notifyObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.update(temperature, humidity, pressure);
            }
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}