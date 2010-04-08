using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  class CombinedFilter_AND : CombinedFilter
  {
    public CombinedFilter_AND(string name, IFilter f1, IFilter f2)
      : base(name, f1, f2)
    { }
    public override bool apply(IEmail email)
    {
      return _filter1.apply(email) && _filter2.apply(email);
    }
  }
}

