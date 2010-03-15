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
            if (!listObservers.Contains(o))
                listObservers.Add(o);
            else throw new DuplicateWaitObjectException();
        }
        public void notifyObserver()
        {
            foreach (IObserver item in listObservers)
                item.updateDelete();
        }
        public void DetachObserver(IObserver o)
        {
            if (listObservers.Contains(o))
                listObservers.Remove(o);
            else
                throw new KeyNotFoundException();
        }
    }
}
