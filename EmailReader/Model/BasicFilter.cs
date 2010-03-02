using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
    public class BasicFilter : IFilter, IObserver, ISubject
    {
        private Subject subject;
        string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        string _TagName;
        IOperator _Operator;

        public BasicFilter(string tagName, IOperator filterOperator, string criteria)
        {
            _TagName = tagName;
            _Operator = filterOperator;
        }
        public void updateEdit(Object o)
        {
        }
        public void updateDelete()
        {
        }

        public bool apply(int emailID)
        { return false; }

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
