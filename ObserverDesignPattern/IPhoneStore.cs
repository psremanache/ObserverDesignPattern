using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class IPhoneStore:IObservate
    {
        public int _noOfIphones { get; set; }
        public List<IObserver> _observers;//people who are subscribing

        public IPhoneStore()
        {
            _noOfIphones = 0;
            _observers = new List<IObserver>();
        }
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyAllObserver()
        {
            foreach(var observer in _observers)
            {
                observer.SendMessage(_noOfIphones);
            }
        }

        public void UpdateData(int data)
        {
            if(_noOfIphones == 0 && data > 0)
            {
                _noOfIphones = data;
                NotifyAllObserver();
            }
            else
            {
                _noOfIphones = data;
            }
            
        }
    }
}
