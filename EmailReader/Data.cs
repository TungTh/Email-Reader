using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using EmailReader.Model;
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

      //create default tags
      ObservableTag _fromTag = new Tag("From", true);
      ObservableTag _toTag = new Tag("To", true);
      ObservableTag _contentTag = new Tag("Content", true);
      ObservableTag _sentTag = new Tag("SentDate", true);

      _Tags.Add(_fromTag);
      _Tags.Add(_toTag);
      _Tags.Add(_contentTag);
      _Tags.Add(_sentTag);

      for (int i = 0; i < 100; i++)
      {
        Email email = new Email(i);
        _Emails.Add(email);
        _fromTag.tagEmail(email, "Sender " + i.ToString());
        _toTag.tagEmail(email, "Receiver " + (i % 5).ToString());
        _contentTag.tagEmail(email, "This is testing email " + i.ToString());
        _sentTag.tagEmail(email, "2010-03-18 09:" + (i % 60).ToString().PadLeft(2, '0'));
      }
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
