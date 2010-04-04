using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  class EditEmailTag:IAction
  {
    ITag _tag = null;
    IEmail _email = null;
    string _newValue = null;
    internal EditEmailTag (ITag tag, IEmail email, string newValue){
      _tag = tag;
      _email = email;
      _newValue = newValue;
    }
    public void execute()
    {
      _tag.editEmailTag(_email, _newValue);
    }
  }
}
