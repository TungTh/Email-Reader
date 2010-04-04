using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  class RenameTag : IAction
  {
    ITag _tag;
    string _name;
    internal RenameTag(ITag tag, string name)
    {
      _tag = tag;
      _name = name;
    }

    public void execute()
    {
      _tag.rename(_name);
    }
  }
}
