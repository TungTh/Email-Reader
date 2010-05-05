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
      Data.insertTag(_tag);
    }

    internal InsertTag(ITag tag)
    {
      _tag = tag;
    }
  }
}
