using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public interface IObservate
    {
        public void AddObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void UpdateData(int data);
        public void NotifyAllObserver();
        public string GetName();
        public int GetItemsCount();

    }
}
