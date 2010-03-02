using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  public class DeleteComboFilter : IAction
  {
    Test _receiver = null;
    string _parameter = null;
    public DeleteComboFilter(Test receiver, string ComboFilter)
    {
      _receiver = receiver;
      _parameter = ComboFilter;
    }
    public void Execute()
    {
      _receiver.DeleteComboFilter(_parameter);
    }
  }
}
