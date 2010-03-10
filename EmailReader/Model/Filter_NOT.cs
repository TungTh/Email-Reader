using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;

namespace EmailReader.Model
{
    class Filter_NOT : IFilter, IObserver, ISubject
    {
        private Subject subject;
        private IFilter filter;
        string _Name;
        public Filter_NOT(IFilter filter)
        {
            this.filter = filter;
        }
        public string Name
        {
            get { return _Name; }
        }
        public bool apply(IEmail email)
        {
            return !this.filter;
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
        public void updateDelete()
        {
        }
    }
}
