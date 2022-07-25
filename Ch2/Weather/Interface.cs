using System;
using Weather;
namespace Weather
{
    public interface ISubject
    {
        void registerObserver(IObserver o);
        void removeObserver(IObserver o);
        void notifyObservers();
    }

    public interface IObserver
    {
        void update(float temp, float humidity, float pressure);
    }

    public interface IDisplayElement
    {
        void display();
    }
}