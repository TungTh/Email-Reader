using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  public interface IOperator
  {
    string Name { get;}

    bool validateInput(string value, string criteria);

    bool apply(string value, string criteria);
  }
}
