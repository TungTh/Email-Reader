using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;

namespace EmailReader.Model
{
  public abstract class CombinedFilter : AbstractFilter
  {
    protected IFilter filter1, filter2;

    public CombinedFilter(string name, IFilter f1, IFilter f2):base(name)
    {
      this.filter1 = f1;
      this.filter2 = f2;
      filter1.attachObserver(this);
      filter2.attachObserver(this);
    }

    public override void updateDelete()
    {
        filter1.detachObserver(this);
        filter2.detachObserver(this);
        notifyObserver();
        Data.removeFilter(this);      
    }

  }

}
