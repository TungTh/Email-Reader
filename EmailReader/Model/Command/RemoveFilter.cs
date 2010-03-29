using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  class RemoveFilter:IAction
  {IFilter _filter = null;
    internal RemoveFilter(IFilter filter)
    {
      _filter = filter;
    }

    public void execute()
    {
      System.Diagnostics.Debug.WriteLine("Remove filter: " + _filter.Name);
      Data.removeFilter(_filter);
    }

    public override string ToString()
    {
      return base.ToString() + " - " + _filter.Name;
    }
  }
}
