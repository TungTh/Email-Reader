using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;
namespace EmailReader.Model
{

  public class Tag : ObservableTag
  {
    Dictionary<IEmail, string> _TaggedEmails = new Dictionary<IEmail, string>();

    public Tag(string name, bool isDefault) : base(name, isDefault) { }

    public override void tagEmail(IEmail email, string value)
    {
      if (!_TaggedEmails.ContainsKey(email))
        _TaggedEmails.Add(email, value);
      else throw new Exception("This email was already existed");
    }

    public override void untagEmail(IEmail email)
    {
      if (_TaggedEmails.ContainsKey(email))
        _TaggedEmails.Remove(email);
      else throw new Exception("This email can not untag because it was not existed");
    }

    public override void editEmailTag(IEmail email, string newValue)
    {
      untagEmail(email);
      tagEmail(email, newValue);
    }

    public override string getEmailTag(IEmail email)
    {
      if (!_TaggedEmails.ContainsKey(email))
        throw new Exception("This email was not existed");
      return _TaggedEmails[email];

    }

    public override bool hasTag(IEmail email)
    {
      return _TaggedEmails.ContainsKey(email);
    }
  }

}

