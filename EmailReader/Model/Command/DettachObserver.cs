using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;
namespace EmailReader.Model.Command
{
  class DettachObserver:IAction
  {
    ISubject _subject;
    IObserver _obs;
    internal DettachObserver(ISubject subject, IObserver obs)
    {
      _subject = subject;
      _obs = obs;
    }

    public void execute()
    {
      _subject.detachObserver(_obs);
    }
  }
}
