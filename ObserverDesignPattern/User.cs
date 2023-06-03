using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class User:IObserver
    {

        public void SendMessage(int noOfIphones)
        {
            Console.WriteLine("New Iphone stock is introduced {0}", noOfIphones);
        }
        public void Subscribe(IObservate observate)
        {
            observate.AddObserver(this);
        }
        public void Unsubscribe(IObservate observate)
        {
            observate.RemoveObserver(this);
        }
    }
}
