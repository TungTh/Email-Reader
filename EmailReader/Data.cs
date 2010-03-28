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

    static Data()
    {
      _Emails = new List<IEmail>();
      _Tags = new List<ITag>();
      _Filters = new List<IFilter>();

      //create default tags, Hai: don't reorder or modify it, please 
      ObservableTag _fromTag = new Tag("From", true);
      ObservableTag _toTag = new Tag("To", true);
      ObservableTag _subjectTag = new Tag("Subject", true); //Hai fix 
      ObservableTag _sentTag = new Tag("SentDate", true);

      _Tags.Add(_fromTag);
      _Tags.Add(_toTag);
      _Tags.Add(_subjectTag);
      _Tags.Add(_sentTag);

      for (int i = 0; i < 100; i++)
      {
        Email email = new Email(i);
        _Emails.Add(email);
        _fromTag.tagEmail(email, "Sender " + i.ToString());
        _toTag.tagEmail(email, "Receiver " + (i % 5).ToString());
        _subjectTag.tagEmail(email, "Subject of email " + i.ToString()); //Hai fix
        _sentTag.tagEmail(email, "2010-03-18 09:" + (i % 60).ToString().PadLeft(2, '0'));
      }

      //hai add default filter
      IFilter filterForm5 = new BasicFilter("From 5", _fromTag, StringContaining.getInstance(), "5");
      IFilter filterTo2 = new BasicFilter("To 2", _toTag, StringContaining.getInstance(), "2");
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
