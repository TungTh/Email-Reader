using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using EmailReader.Model;
using EmailReader.Model.Operator;
using EmailReader.Model.Command;
namespace EmailReader
{
  public static class Data
  {
    static List<IEmail> _Emails;

    static List<ITag> _Tags;

    static List<IFilter> _Filters;

    static List<IOperator> _Operators; //Hai add default operators

    static IActionHandler _ActionHandler = new ActionHandler();

    public static ITag FromTag = new Tag("From", true);
    public static ITag ToTag = new Tag("To", true);
    public static ITag SubjectTag = new Tag("Subject", true); //Hai fix 
    public static ITag SentDateTag = new Tag("SentDate", true);
    public static ITag SignatureTag = new Tag("Signature", false); //Hai add for demo, don't remove

    public static IActionHandler ActionHandler
    {
      get { return _ActionHandler; }
      set { _ActionHandler = value; }
    }

    static Data()
    {
      _Emails = new List<IEmail>();
      _Tags = new List<ITag>();
      _Filters = new List<IFilter>();
      _Operators = new List<IOperator>();

      InitData();
    }

    private static void InitData()
    {
      _Tags.Add(FromTag);
      _Tags.Add(ToTag);
      _Tags.Add(SubjectTag);
      _Tags.Add(SentDateTag);
      _Tags.Add(SignatureTag);

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
      insertFilter(filterForm5);
      insertFilter(filterTo2);

      _Operators.Add(StringContaining.getInstance());
      _Operators.Add(StringEquals.getInstance());
    }

    public static ICollection<IEmail> getEmailCollection()
    {
      return Data._Emails;
    }

    public static ICollection<ITag> getTagCollection()
    {
      return Data._Tags;
    }

    public static ICollection<IFilter> getFilterCollection()
    {
      return Data._Filters;
    }

    public static ICollection<IOperator> getOperatorCollection()
    {
      return Data._Operators;
    }

    #region Tags
    public static void insertTag(ITag tag)
    {
      ActionHandler.storeAction(new RemoveTag(tag));
      _Tags.Add(tag);
    }

    public static void removeTag(ITag tag)
    {
      ActionHandler.beginMacro();
      tag.notifyObserver();
      ActionHandler.storeAction(new InsertTag(tag));
      _Tags.Remove(tag);
      ActionHandler.endMacro();
    }
    #endregion

    #region Filters
    public static void insertFilter(IFilter filter)
    {
      ActionHandler.storeAction(new RemoveFilter(filter));
      _Filters.Add(filter);
    }

    public static void removeFilter(IFilter filter)
    {
      filter.updateDelete();
    }

    public static void replaceFilter(IFilter oldFilter, IFilter newFilter)
    {
      ActionHandler.beginMacro();

      removeFilter(oldFilter);
      insertFilter(newFilter);

      ActionHandler.endMacro();
    }

    public static bool constainsFilter(string filterName)
    {
      foreach (IFilter filter in _Filters)
      {
        if (filter.Name == filterName) return true;
      }
      return false;
    }

    internal static void directRemoveFilter(IFilter filter)
    {
      ActionHandler.storeAction(new InsertFilter(filter));
      _Filters.Remove(filter);
    }
    #endregion

  }
}
