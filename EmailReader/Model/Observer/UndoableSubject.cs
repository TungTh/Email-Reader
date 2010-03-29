using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Command;
namespace EmailReader.Model.Observer
{
  public class UndoableSubject : ISubject
  {
    Subject _subject = new Subject();

    #region ISubject Members
    public void attachObserver(IObserver o)
    {
      Data.ActionHandler.storeAction(new DettachObserver(_subject, o));
      _subject.attachObserver(o);
    }

    public void notifyObserver()
    {
      _subject.notifyObserver();
    }

    public void detachObserver(IObserver o)
    {
      Data.ActionHandler.storeAction(new AttachObserver(_subject, o));
      _subject.detachObserver(o);
    }

    #endregion
  }
}
