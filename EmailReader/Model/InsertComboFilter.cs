using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  public class InsertComboFilter: IAction
  {
    Test _receiver = null;
    string _parameter = null;
    public InsertComboFilter(Test receiver, string ComboFilter)
    {
      _receiver = receiver;
      _parameter = ComboFilter;
    }
    public void Execute()
    {
      _receiver.InsertComboFilter(_parameter);
    }
  }
}
