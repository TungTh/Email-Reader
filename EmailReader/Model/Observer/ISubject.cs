using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Observer
{
    public interface ISubject
    {
        void AttachObserver(IObserver o);
        void notifyObserver();
        void DetachObserver(IObserver o);
    }
}
