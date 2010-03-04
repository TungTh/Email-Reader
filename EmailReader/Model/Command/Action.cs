using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  public class Action : IAction
  {
    string _name;
    public Action(string name)
    {
      _name = name;
    }

    public void execute()
    {
      System.Diagnostics.Debug.WriteLine(_name);
    }
  }
}
