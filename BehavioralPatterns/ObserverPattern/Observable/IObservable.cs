﻿using ObserverPattern.Observer;

namespace ObserverPattern.Observable
{
    internal interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }
}
