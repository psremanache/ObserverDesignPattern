using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class ItemStore : IObservate
    {
        public List<IObserver> _subscriberList { get; set; }
        public int _itemsCount { get; set; }
        public string _itemName { get; set; }

        public ItemStore(string ItemName)
        {
            _itemsCount = 0;
            _subscriberList = new List<IObserver>();
            _itemName = ItemName;
        }
        public void AddObserver(IObserver observer)
        {
            _subscriberList.Add(observer);
        }

        public void NotifyAllObserver()
        {
            foreach(var subscriber in _subscriberList)
            {
                subscriber.NotifyUser(this);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            _subscriberList.Remove(observer);
        }

        public void UpdateData(int data)
        {
            if(_itemsCount == 0)
            {
                _itemsCount = data;
                NotifyAllObserver();
            }
        }

        public int GetItemsCount()
        {
            return _itemsCount;
        }
        public string GetName()
        {
            return _itemName;
        }
    }
}
