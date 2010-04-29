using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model;

namespace EmailReader.View
{
  class FilterBriefInfo
  {
    IFilter _filter;

    public string Name
    {
      get
      {
        return _filter.Name;
      }
    }

    private bool isSelected;

    public bool IsSelected
    {
      get { return isSelected; }
      set { isSelected = value; }
    }

    public IFilter Filter
    {
      get
      {
        return _filter;
      }
    }

    public FilterBriefInfo(IFilter filter)
    {
      this._filter = filter;
    }
  }
}
