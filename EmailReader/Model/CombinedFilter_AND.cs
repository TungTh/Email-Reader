using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
    class CombinedFilter_AND : CombinedFilter
    {
        public CombinedFilter_AND(IFilter f1, IFilter f2)
            : base(f1, f2)
        { }
        public override bool apply(IEmail email)
        {
         
            return false;
        }

    }
}

