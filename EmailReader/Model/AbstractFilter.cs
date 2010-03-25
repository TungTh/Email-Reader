using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;
namespace EmailReader.Model
{
  public abstract class AbstractFilter : IFilter
  {
    string _name = null;
    Subject _subject = new Subject();

    #region ISubject Members

    public void attachObserver(IObserver o)
    {
      _subject.attachObserver(o);
    }

    public void notifyObserver()
    {
      _subject.notifyObserver();
    }

    public void detachObserver(IObserver o)
    {
      _subject.detachObserver(o);
    }

    #endregion

    public string Name { get { return _name; } }

    public abstract bool apply(IEmail email);

    public abstract void updateDelete();

    public AbstractFilter(string name)
    {
      _name = name;
    }
  }
}
