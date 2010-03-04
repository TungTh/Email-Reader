using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Observer
{
    public class Subject : ISubject
    {
        List<IObserver> listObservers;
        public Subject()
        {
            listObservers = new List<IObserver>();
        }
      public void AttachObserver(IObserver o)
        {
        }
        public void notifyObserver()
        {
        }
        public void DetachObserver(IObserver o)
        {
        }
    }
}
