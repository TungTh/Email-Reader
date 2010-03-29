using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  class TagEmail:IAction
  {
    ITag _tag = null;
    IEmail _email = null;
    string _value = null;
    internal TagEmail(ITag tag, IEmail email,string value)
    {
      _tag = tag;
      _email = email;
      _value = value;
    }

    public void execute()
    {
      _tag.tagEmail(_email, _value);
    }
  }
}
