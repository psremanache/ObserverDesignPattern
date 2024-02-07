using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class User:IObserver
    {
        public void NotifyUser(IObservate observate)
        {
            Console.WriteLine("{0} product is filled with new {1} items", observate.GetName(), observate.GetItemsCount());
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
