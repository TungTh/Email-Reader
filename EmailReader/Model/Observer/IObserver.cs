using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Observer
{
    public interface IObserver
    {
        void updateEdit(Object o);
        void updateDelete();
    }
}
