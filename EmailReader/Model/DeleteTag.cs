using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  public class DeleteTag : IAction
  {
    Test _receiver = null;
    string _parameter = null;
    public DeleteTag(Test receiver, string Tag)
    {
      _receiver = receiver;
      _parameter = Tag;
    }
    public void Execute()
    {
      _receiver.DeleteTag(_parameter);
    }
  }
}
