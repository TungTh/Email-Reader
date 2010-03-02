using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  public class InsertBasicFilter : IAction
  {
    Test _receiver = null;
    string _parameter = null;
    public InsertBasicFilter(Test receiver, string BasicFilter)
    {
      _receiver = receiver;
      _parameter = BasicFilter;
    }
    public void Execute()
    {
      _receiver.InsertBasicFilter(_parameter);
    }
  }
}
