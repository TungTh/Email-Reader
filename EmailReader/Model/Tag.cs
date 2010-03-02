using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  public class Tag : EmailReader.Model.ITag
  {
    private Subject subject;
    string _Name;
    public string Name
    {
      get { return _Name; }
    }

    bool _IsDefaultTag;
    public bool IsDefaultTag
    {
      get { return _IsDefaultTag; }
    }

    Dictionary<int, string> _TaggedEmails = new Dictionary<int, string>();

    protected Tag()
    {        
    }

    public void tagEmail(int emailID, string value) { }

    public void untagEmail(int emailID) { }

    public void editEmailTag(int emailID, string newValue) { }

    public string getEmailTag(int emailID)
    {
      return _TaggedEmails[emailID];
    }
  }
}
