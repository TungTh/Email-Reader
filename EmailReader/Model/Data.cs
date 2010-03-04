using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace EmailReader.Model
{
  public static class Data
  {
    static List<IEmail> _Emails;

    static List<ITag> _Tags;

    static List<IFilter> _Filters;

    static public ICollection<IEmail> getEmailCollection()
    {
      return Data._Emails;
    }

    static public ICollection<ITag> getTagCollection()
    {
      return Data._Tags;
    }

    static public ICollection<IFilter> getFilterCollection()
    {
      return Data._Filters;
    }

    #region Tags
    static public void insertTag(ITag tag) { }

    static public void removeTag(ITag tag) { }

    #endregion

 
    #region Filters

    static public void insertFilter(IFilter filter) { }

    static public void removeFilter(IFilter filter) { }

    #endregion

  }
}
