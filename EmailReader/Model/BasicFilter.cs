using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;

namespace EmailReader.Model
{
    public class BasicFilter : IFilter, IObserver, ISubject
    {
        private Subject subject;
        private ISubject targetSubject;
        private string criteria;
        string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        ITag _Tag;
        IOperator _Operator;

        #region Constructor
        public BasicFilter(ITag tag, IOperator filterOperator, string criteria)
        {
            _Tag = tag;
            _Operator = filterOperator;
            this.criteria = criteria;
            subject = new Subject();
        }

        #endregion

        #region Methods
        public bool apply(IEmail email)
        {
            return _Operator.apply(_Tag.getEmailTag(email), criteria);
        }
        #endregion

        #region Observer
        public void updateDelete()
        {
            /* When Tag is deleted, tag will notify to BasicFilter
             * - Tags will detach BasicFilter
             * - BasicFilter notify to its observers
             * - Data remove this BasicFilter
             */
            targetSubject.DetachObserver(this);
            notifyObserver();
            Data.removeFilter(this);

        }
        #endregion

        #region Observable
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
    }
}
