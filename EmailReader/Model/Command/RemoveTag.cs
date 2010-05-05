using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  class RemoveTag : IAction
  {
    ITag _tag = null;
    internal RemoveTag(ITag tag)
    {
      _tag = tag;
    }

    public void execute()
    {
      Data.removeTag(_tag);
    }
  }
}
