using ObserverPattern.Observable;

namespace ObserverPattern.Observer
{
    internal class PhoneDevice : IObserver
    {
        private readonly WeatherStation weatherStation;

        public PhoneDevice(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
            weatherStation.Add(this);
        }

        public void Update()
        {
            Console.WriteLine($"PhoneDevice here. The temp is: {weatherStation.Temperature}");
        }
    }
}
