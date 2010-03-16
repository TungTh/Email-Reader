using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;

namespace EmailReader.Model
{
  class Filter_NOT : AbstractFilter
  {
    private IFilter filter;
    public Filter_NOT(string name,IFilter filter):base(name)
    {
      this.filter = filter;
    }
    public override bool apply(IEmail email)
    {
      return !this.filter.apply(email);
    }

    public override void updateDelete()
    {
      throw new NotImplementedException();
    }
  }
}
