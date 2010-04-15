using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model;

namespace EmailReader.View
{
    class FilterBriefInfoForCmb
    {
        IFilter filter;

        public override string ToString()
        {
            return filter.Name;
        }

        public IFilter getFilter()
        {
          return filter;
        }
        

        public FilterBriefInfoForCmb(IFilter filter)
        {
          this.filter = filter;
        }
    }
}
