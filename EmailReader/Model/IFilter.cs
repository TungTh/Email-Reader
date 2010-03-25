using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;

namespace EmailReader.Model
{
  public interface IFilter :ISubject, IObserver
  {
    string Name { get;}
    bool apply(IEmail email);
  }

}
