using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;

namespace EmailReader.Model
{
  public class BasicFilter : AbstractFilter
  {
    private string criteria;
    ITag _Tag;
    IOperator _Operator;

    public BasicFilter(string name, ITag tag, IOperator filterOperator, string criteria)
      : base(name)
    {
      _Tag = tag;
      _Operator = filterOperator;
      _Tag.attachObserver(this);
      this.criteria = criteria;
    }

    public override bool apply(IEmail email)
    {
      return _Tag.hasTag(email) && _Operator.apply(_Tag.getEmailTag(email), criteria);
    }

    protected override void selfDelete()
    {
      _Tag.detachObserver(this);
    }
  }
}
