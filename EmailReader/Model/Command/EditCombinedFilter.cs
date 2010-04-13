using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  class EditCombinedFilter :IAction
  {
    IFilter _newFilter1, _newFilter2;
    CombinedFilter _targetFilter;
    string _newName;
    internal EditCombinedFilter(CombinedFilter targetFilter, string newName, IFilter newFilter1, IFilter newFilter2)
    {
      _targetFilter = targetFilter;
      _newFilter1 = newFilter1;
      _newFilter2 = newFilter2;
      _newName = newName;
    }

    public void execute()
    {
      _targetFilter.edit(_newName, _newFilter1, _newFilter2);
    }
  }
}
