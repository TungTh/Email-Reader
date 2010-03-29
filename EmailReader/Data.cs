using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using EmailReader.Model;
using EmailReader.Model.Operator;

namespace EmailReader
{
  public static class Data
  {
    static List<IEmail> _Emails;

    static List<ITag> _Tags;

    static List<IFilter> _Filters;

    public static ITag FromTag = new Tag("From", true);
    public static ITag ToTag = new Tag("To", true);
    public static ITag SubjectTag = new Tag("Subject", true); //Hai fix 
    public static ITag SentDateTag = new Tag("SentDate", true);

    static Data()
    {
      _Emails = new List<IEmail>();
      _Tags = new List<ITag>();
      _Filters = new List<IFilter>();

      InitData();
    }

    private static void InitData()
    {
      _Tags.Add(FromTag);
      _Tags.Add(ToTag);
      _Tags.Add(SubjectTag);
      _Tags.Add(SentDateTag);

      for (int i = 0; i < 100; i++)
      {
        Email email = new Email(i);
        _Emails.Add(email);
        FromTag.tagEmail(email, "Sender " + i.ToString());
        ToTag.tagEmail(email, "Receiver " + (i % 5).ToString());
        SubjectTag.tagEmail(email, "Subject of email " + i.ToString()); //Hai fix
        SentDateTag.tagEmail(email, "2010-03-18 09:" + (i % 60).ToString().PadLeft(2, '0'));
      }

      //hai add default filter
      IFilter filterForm5 = new BasicFilter("From 5", FromTag, StringContaining.getInstance(), "5");
      IFilter filterTo2 = new BasicFilter("To 2", ToTag, StringContaining.getInstance(), "2");
      _Filters.Add(filterForm5);
      _Filters.Add(filterTo2);
    }

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
    static public void insertTag(ITag tag) { _Tags.Add(tag); }

    static public void removeTag(ITag tag)
    {
      tag.notifyObserver();
      _Tags.Remove(tag);
    }
    #endregion

    #region Filters
    static public void insertFilter(IFilter filter) { _Filters.Add(filter); }

    static public void removeFilter(IFilter filter)
    {
      filter.notifyObserver();
      _Filters.Remove(filter);
    }
    #endregion

  }
}
