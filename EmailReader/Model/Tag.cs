using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;
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

    public void tagEmail(IEmail email, string value) { }

    public void untagEmail(IEmail email) { }

    public void editEmailTag(IEmail email, string newValue) { }

    public string getEmailTag(IEmail email)
    {
      return null;
    }

    public void rename(string newName) { }
  }
}
