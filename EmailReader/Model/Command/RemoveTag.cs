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
      System.Diagnostics.Debug.WriteLine("Remove tag: " + _tag.Name);
      Data.removeTag(_tag);
    }
  }
}
