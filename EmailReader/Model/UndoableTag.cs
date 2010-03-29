using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Command;
namespace EmailReader.Model
{
  public class UndoableTag : Tag
  {
    public UndoableTag(string name, bool isDefault) : base(name, isDefault) { }

    public override void editEmailTag(IEmail email, string newValue)
    {
      string oldValue = base.getEmailTag(email);
      Data.ActionHandler.storeAction(new EditEmailTag(this,email,oldValue));
      base.editEmailTag(email, newValue);
    }

    public override void tagEmail(IEmail email, string value)
    {
      Data.ActionHandler.storeAction(new UntagEmail(this, email));
      base.tagEmail(email, value);
    }

    public override void untagEmail(IEmail email)
    {
      string currentEmailTagValue = base.getEmailTag(email);
      Data.ActionHandler.storeAction(new TagEmail(this, email,currentEmailTagValue));
      base.untagEmail(email);
    }
  }
}
