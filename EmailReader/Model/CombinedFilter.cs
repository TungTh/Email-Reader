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
    }

    public override void updateDelete()
    {
      throw new NotImplementedException();
    }

  }
}
