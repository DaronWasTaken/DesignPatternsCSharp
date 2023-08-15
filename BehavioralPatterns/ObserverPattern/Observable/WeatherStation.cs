using ObserverPattern.Observer;

namespace ObserverPattern.Observable
{
    internal class WeatherStation : IObservable
    {
        private List<IObserver> observers;
        public int Temperature
        {
            get => _temperature;

            set
            {
                _temperature = value;
                Notify();
            }
        }

        private int _temperature;

        public WeatherStation()
        {
            observers = new List<IObserver>();
        }


        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
                observer.Update();
        }
    }
}