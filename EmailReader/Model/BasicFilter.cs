using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;

namespace EmailReader.Model
{
  public class BasicFilter : IFilter, IObserver, ISubject
  {
    private Subject subject;
    private string criteria;
    string _Name;
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    ITag _Tag;
    IOperator _Operator;

    public BasicFilter(ITag tag, IOperator filterOperator, string criteria)
    {
      _Tag = tag;
      _Operator = filterOperator;
      this.criteria = criteria;
    }

    public void updateDelete()
    {
    }

    public bool apply(IEmail email)
    {
      return  _Operator.apply(_Tag.getEmailTag(email), criteria);
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
