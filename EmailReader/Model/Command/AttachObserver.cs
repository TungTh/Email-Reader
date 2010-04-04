using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;
namespace EmailReader.Model.Command
{
  class AttachObserver:IAction
  {
    ISubject _subject=null;
    IObserver _obs=null;
    internal AttachObserver(ISubject subject, IObserver obs)
    {
      _subject = subject;
      _obs = obs;
    }

    public void execute()
    {
      System.Diagnostics.Debug.WriteLine("Attach Observer: " + _obs.ToString());
      _subject.attachObserver(_obs);
    }
  }
}
