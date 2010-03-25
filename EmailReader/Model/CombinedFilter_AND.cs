using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
    class CombinedFilter_AND : CombinedFilter
    {
        public CombinedFilter_AND(string name, AbstractFilter f1, AbstractFilter f2)
            : base(name, f1, f2)
        {}
        public override bool apply(IEmail email)
        {               
            return filter1.apply(email) && filter2.apply(email);
        }
       
    }
}

