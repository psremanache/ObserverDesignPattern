﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public interface IObserver
    {
        public void SendMessage(int noOfIphones);
        public void Subscribe(IObservate observate);
        public void Unsubscribe(IObservate observate);
    }
}
