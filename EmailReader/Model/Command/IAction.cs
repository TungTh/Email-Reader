using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  public interface IAction
  {
    void execute();
  }
}
