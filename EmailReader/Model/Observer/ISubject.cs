using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Observer
{
    public interface ISubject
    {
        void attachObserver(IObserver o);
        void notifyObserver();
        void detachObserver(IObserver o);
    }
}
