using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  public class DeleteBasicFilter:IAction
  {
    Test _receiver = null;
    string _parameter = null;
    public DeleteBasicFilter(Test receiver, string BasicFilter)
    {
      _receiver = receiver;
      _parameter = BasicFilter;
    }
    public void Execute()
    {
      _receiver.DeleteBasicFilter(_parameter);
    }
  }
}
