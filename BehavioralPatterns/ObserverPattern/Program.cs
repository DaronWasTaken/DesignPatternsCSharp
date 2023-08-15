using ObserverPattern.Observable;
using ObserverPattern.Observer;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            WeatherStation weatherStation = new WeatherStation();

            weatherStation.Temperature = 10;

            PhoneDevice phoneDevice = new PhoneDevice(weatherStation);
            MonitorDevice monitorDevice = new MonitorDevice(weatherStation);

            weatherStation.Temperature = 20;

            weatherStation.Temperature = 30;

            weatherStation.Remove(monitorDevice);

            weatherStation.Temperature = 20;


        }
    }
}