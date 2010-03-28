using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model;

namespace EmailReader.View
{
    class FilterBriefInfo
    {
        string name;
        IFilter filter;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public IFilter Filter
        {
            get
            {
                return filter;
            }
        }

        public FilterBriefInfo(IFilter filter)
        {
            this.filter = filter;
        }
    }
}
