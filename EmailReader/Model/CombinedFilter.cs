using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;

namespace EmailReader.Model
{
    public class CombinedFilter : IFilter, IObserver, ISubject
    {
        protected Subject subject;
        protected IFilter filter1, filter2;
        protected ISubject targetSubject;
        string _Name;
        public string Name
        {
            get { return _Name; }
        }

        public CombinedFilter(IFilter f1, IFilter f2)
        {
            this.filter1 = f1;
            this.filter2 = f2;
        }

        public virtual bool apply(IEmail email)
        {
            throw new System.NotImplementedException();
        }

        public void updateDelete()
        {
            targetSubject.DetachObserver(this);
            notifyObserver();
            Data.removeFilter(this);

        }
        public void AttachObserver(IObserver o)
        {
            subject.AttachObserver(o);
        }
        public void notifyObserver()
        {
            subject.notifyObserver();
        }
        public void DetachObserver(IObserver o)
        {
            subject.DetachObserver(o);
        }
    }
}
