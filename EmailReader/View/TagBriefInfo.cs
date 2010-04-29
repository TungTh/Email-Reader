using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model;

namespace EmailReader.View
{
  class TagBriefInfo
  {
    private ITag _tag;
    private string _name, _tag_value;

    public string Name
    {
      get
      { return _name; }
      set
      { _name = value; }
    }

    public string Value
    {
      get
      { return _tag_value; }
      set
      { _tag_value = value; }
    }

    public void setTag(ITag tag)
    {
      this._tag = tag;
    }

    public ITag getTag()
    {
      return _tag;
    }

    public TagBriefInfo(ITag tag, string name, string value)
    {
      this._tag = tag;
      this._name = name;
      this._tag_value = value;
    }
  }
}
