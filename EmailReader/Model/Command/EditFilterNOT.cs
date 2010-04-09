using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  class EditFilterNOT:IAction
  {
    Filter_NOT _target;
    IFilter _newFilter;
    internal EditFilterNOT(Filter_NOT target, IFilter newFilter)
    {
      _target = target;
      _newFilter = newFilter;
    }

    public void execute()
    {
      _target.edit(_newFilter);
    }
  }
}
