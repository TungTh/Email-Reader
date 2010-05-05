using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  class InsertFilter:IAction
  {
    IFilter _filter = null;
    internal InsertFilter(IFilter filter)
    {
      _filter = filter;
    }

    public void execute()
    {
      Data.insertFilter(_filter);
    }

    public override string ToString()
    {
      return base.ToString() +" - " +_filter.Name;
    }
  }
}
