using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
    public interface IObserver
    {
        void updateEdit(Object o);
        void updateDelete();
    }
}
