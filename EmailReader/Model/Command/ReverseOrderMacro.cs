using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  class ReverseOrderMacro : IAction
  {
    Stack<IAction> _stack = new Stack<IAction>();
    public ReverseOrderMacro() { }
    public void Add(IAction action)
    {
      _stack.Push(action);
    }
    public void execute()
    {
      while (_stack.Count > 0)
      {
        _stack.Pop().execute();
      }
    }
  }
}
