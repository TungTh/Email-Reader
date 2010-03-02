using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  public class InsertTag : IAction
  {
    Test _receiver = null;
    string _parameter = null;
    public InsertTag(Test receiver, string Tag)
    {
      _receiver = receiver;
      _parameter = Tag;
    }
    public void Execute()
    {
      _receiver.InsertTag(_parameter);
    }
  }
}
