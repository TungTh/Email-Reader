using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;
using EmailReader.Model.Command;
namespace EmailReader.Model
{
  public abstract class CombinedFilter : AbstractFilter
  {
    protected IFilter _filter1, _filter2;

    /// <summary>
    /// Warning: modify this object will affect on the main filter
    /// </summary>
    public IFilter Filter1
    {

      get { return _filter1; }
    }

    /// <summary>
    /// Warning: modify this object will affect on the main filter
    /// </summary>
    public IFilter Filter2
    {
      get { return _filter2; }
    }

    public CombinedFilter(string name, IFilter f1, IFilter f2)
      : base(name)
    {
      this._filter1 = f1;
      this._filter2 = f2;
      _filter1.attachObserver(this);
      _filter2.attachObserver(this);
    }

    protected override void selfDelete()
    {
      _filter1.detachObserver(this);
      _filter2.detachObserver(this);
    }

    public void edit(string name, IFilter f1, IFilter f2)
    {
      Data.ActionHandler.beginMacro();
      Data.ActionHandler.storeAction(new EditCombinedFilter(this, this.Name, this.Filter1, this.Filter2));
      _name = name;
      _filter1.detachObserver(this);
      _filter2.detachObserver(this);

      _filter1 = f1;
      _filter2 = f2;

      _filter1.attachObserver(this);
      _filter2.attachObserver(this);
      Data.ActionHandler.endMacro();
    }
  }
}
