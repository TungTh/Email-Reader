using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;
namespace EmailReader.Model
{
  public abstract class AbstractFilter : IFilter
  {
    protected string _name = null;
    ISubject _subject = new UndoableSubject();

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

    public void updateDelete()
    {
      Data.ActionHandler.beginMacro();
      notifyObserver();
      selfDelete();
      Data.directRemoveFilter(this);
      Data.ActionHandler.endMacro();
    }
    protected abstract void selfDelete();
    public AbstractFilter(string name)
    {
      _name = name;
    }
  }
}
