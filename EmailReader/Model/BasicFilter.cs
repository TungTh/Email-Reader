using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;

namespace EmailReader.Model
{
    public class BasicFilter :  IObserver
    {       
        private TagSubject tagSubject;     
        private string criteria;
        string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        
        IOperator _Operator;

        #region Constructor
        public BasicFilter(TagSubject tagSubject, IOperator filterOperator, string criteria)
        {
            this.tagSubject = tagSubject;
            _Operator = filterOperator;
            this.criteria = criteria;
            tagSubject.AttachObserver(this);
            
        }
        #endregion

        #region Methods
        public bool apply(IEmail email)
        {
            return _Operator.apply(tagSubject.getEmailTag(email), criteria);
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
            tagSubject.DetachObserver(this);
            notifyObserver();
            Data.removeFilter(this);

        }
        #endregion
    }
}
