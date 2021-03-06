using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  class InsertTag : IAction
  {
    ITag _tag = null;
    public void execute()
    {
      System.Diagnostics.Debug.WriteLine("Insert Tag: " + _tag.Name);
      Data.insertTag(_tag);
    }

    internal InsertTag(ITag tag)
    {
      _tag = tag;
    }
  }
}
