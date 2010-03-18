using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;

namespace EmailReader.Model
{
  class Filter_NOT : AbstractFilter
  {
    private IFilter filter;
    public Filter_NOT(string name,IFilter filter):base(name)
    {

        private Subject subject;
        private IFilter filter;
        private ISubject targetSubject;
        string _Name;

        #region Constructor
        public Filter_NOT(IFilter filter)
        {
            this.filter = filter;
            subject = new Subject();
            targetSubject.AttachObserver(this);
        }
        #endregion 

        public string Name
        {
            get { return _Name; }
        }
        public bool apply(IEmail email)
        {
            return !this.filter;
        }

        #region Obseverble
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

        #endregion

        #region Observer
        public void updateDelete()
        {
            targetSubject.DetachObserver(this);
            notifyObserver();
            Data.removeFilter(this);
        }
        #endregion

   
    }
 
  }
}
