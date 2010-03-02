using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
    class Filter_NOT : IFilter, IObserver, ISubject
    {
        private Subject subject;
        string _Name;
        public string Name
        {
            get { return _Name; }
        }
        public bool apply(int emailID)
        {
            return false;
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
        public void updateEdit(Object o)
        {
        }
        public void updateDelete()
        {
        }
    }
}
