using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;

namespace EmailReader.Model
{
  public class Filter_NOT : AbstractFilter
  {
    private IFilter filter;

    public Filter_NOT(string name, IFilter filter)
      : base(name)
    {
      this.filter = filter;
      this.filter.attachObserver(this);
    }

    public override bool apply(IEmail email)
    {
      return !this.filter.apply(email);
    }

    #region Observer
    public override void updateDelete()
    {
      filter.detachObserver(this);
      notifyObserver();
      Data.removeFilter(this);
    }
    #endregion


  }

}
