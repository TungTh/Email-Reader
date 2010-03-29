using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  class UntagEmail:IAction 
  {
    ITag _tag=null;
    IEmail _email = null;

    internal UntagEmail(ITag tag, IEmail email)
    {
      _tag = tag;
      _email = email;
    }

    public void execute()
    {
      _tag.untagEmail(_email);
    }
  }
}
