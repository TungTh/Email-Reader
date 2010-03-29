using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model;

namespace EmailReader.View
{
  class FilterBriefInfo
  {
    IFilter filter;

    public string Name
    {
      get
      {
        return filter.Name;
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
        return filter;
      }
    }

    public FilterBriefInfo(IFilter filter)
    {
      this.filter = filter;
    }
  }
}
