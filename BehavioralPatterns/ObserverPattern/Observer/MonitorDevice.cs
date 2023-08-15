using ObserverPattern.Observable;

namespace ObserverPattern.Observer
{
    internal class MonitorDevice : IObserver
    {
        private readonly WeatherStation weatherStation;

        public MonitorDevice(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
            weatherStation.Add(this);
        }

        public void Update()
        {
            Console.WriteLine($"MonitorDevice here. The temp is: {weatherStation.Temperature}");
        }
    }
}
