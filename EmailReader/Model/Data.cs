using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace EmailReader.Model
{
  public static class Data
  {
    static Dictionary<int, IEmail> _Emails;

    static Dictionary<int, ITag> _Tags;

    static Dictionary<int, IFilter> _Filters;

    static public ICollection<IEmail> getEmailCollection()
    {
      return Data._Emails.Values;
    }

    static public ICollection<ITag> getTagCollection()
    {
      return Data._Tags.Values;
    }

    static public ICollection<IFilter> getFilterCollection()
    {
      return Data._Filters.Values;
    }
    #region Tags
    static public void insertTag(string tagName) { }

    static public void removeTag(string tagName) { }

    static public void renameTag(string tagName, string newName) { }

    static public Tag getTag(string tagName) { return null; }
    #endregion

    #region Emails
    static public void getEmail(int emailID) { }
    #endregion

    #region Filters

    static public void insertFilter(IFilter filter){}

    static public void removeFilter(string filterName){}

    static public void updateFilter(string filterName, IFilter newFilter) { }

    static public IFilter getFilter(string filterName) { return null; }

#endregion

  }
}
