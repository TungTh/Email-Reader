using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  public interface IFilter
  {
    string Name { get;}
    bool apply(IEmail email);
  }

}
