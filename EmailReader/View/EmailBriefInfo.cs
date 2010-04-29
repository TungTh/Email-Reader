using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model;

namespace EmailReader.View
{
  class EmailBriefInfo
  {
    private string _date, _from, _to, _subject;
    private IEmail _email;

    public string Date
    {
      get
      { return _date; }

      set
      { _date = value; }
    }

    public string From
    {
      get
      { return _from; }

      set
      { _from = value; }
    }

    public string To
    {
      get
      { return _to; }

      set
      { _to = value; }
    }

    public string Subject
    {
      get
      { return _subject; }

      set
      { _subject = value; }
    }

    public IEmail getEmail()
    {
      return _email;
    }

    public void setEmail(IEmail e)
    {
      this._email = e;
    }

    public EmailBriefInfo(IEmail e)
    {
      this._email = e;
    }
  }
}
