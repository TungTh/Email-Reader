using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Observer
{
  public class Subject : ISubject
  {
    List<IObserver> listObservers;
    public Subject()
    {
      listObservers = new List<IObserver>();
    }
    public void attachObserver(IObserver o)
    {
      if (!listObservers.Contains(o))
        listObservers.Add(o);
    }
    public void notifyObserver()
    {
      // Take a snapshot of listObservers to prevent to situation 
      // when the observer call deattach during the notify loop 
      IObserver[] observers = listObservers.ToArray();
      foreach (IObserver item in observers)
        item.updateDelete();
    }
    public void detachObserver(IObserver o)
    {
      if (listObservers.Contains(o))
        listObservers.Remove(o);
    }
  }
}
