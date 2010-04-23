using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;
using EmailReader.Model.Command;
namespace EmailReader.Model
{
  public class Filter_NOT : AbstractFilter
  {
    private IFilter _filter;

    public IFilter Filter
    {
      get { return _filter; }
    }
    public Filter_NOT(string name, IFilter filter)
      : base(name)
    {
      this._filter = filter;
      this._filter.attachObserver(this);
    }

    public override bool apply(IEmail email)
    {
      return !this._filter.apply(email);
    }

    protected override void selfDelete()
    {
      _filter.detachObserver(this);
    }

    public void edit(IFilter filter)
    {
      Data.ActionHandler.beginMacro();
      Data.ActionHandler.storeAction(new EditFilterNOT(this, _filter));
      _filter.detachObserver(this);
      _filter = filter;
      _filter.attachObserver(this);
      Data.ActionHandler.endMacro();
    }
  }
}
