using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;
using EmailReader.Model.Operator;
using EmailReader.Model.Command;
namespace EmailReader.Model
{
  public class BasicFilter : AbstractFilter
  {
    private string _criteria;
    private ITag _tag;
    private IOperator _operator;

    public string Criteria
    {
      get { return _criteria; }
    }

    /// <summary>
    /// Warning: modify this object will affect on the main filter
    /// </summary>
    public ITag Tag
    {
      get { return _tag; }
    }

    public IOperator Operator
    {
      get { return _operator; }
    }

    public BasicFilter(string name, ITag tag, IOperator filterOperator, string criteria)
      : base(name)
    {
      _tag = tag;
      _operator = filterOperator;
      _tag.attachObserver(this);
      this._criteria = criteria;
    }

    public override bool apply(IEmail email)
    {
      return _tag.hasTag(email) && _operator.apply(_tag.getEmailTag(email), _criteria);
    }

    protected override void selfDelete()
    {
      _tag.detachObserver(this);
    }

    public void edit(string newName, ITag newTag, IOperator newFilterOperator, string newCriteria)
    {
      Data.ActionHandler.beginMacro();
      Data.ActionHandler.storeAction(new EditBasicFilter(this, _name, _tag, _operator, _criteria));
      _name = newName;
      _operator = newFilterOperator;
      _criteria = newCriteria;

      _tag.detachObserver(this);
      _tag = newTag;
      _tag.attachObserver(this);
      Data.ActionHandler.endMacro();
    }
  }
}
