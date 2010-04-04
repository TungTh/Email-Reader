using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model;

namespace EmailReader.View
{
    class TagBriefInfoForCmb
    {
        string name;
        ITag tag;
        
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

        public void setTag(ITag tag)
        {
            this.tag = tag;
        }

        public ITag getTag()
        {
            return tag;
        }

        public override string ToString()
        {
            return name;
        }

        public TagBriefInfoForCmb(ITag tag)
        {
            this.name = tag.Name;
            this.tag = tag;
        }
    }
}
