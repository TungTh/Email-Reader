using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model;

namespace EmailReader.View
{
    class TagBriefInfo
    {
        ITag tag;
        string name, tag_value;

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

        public string Value
        {
            get
            {
                return tag_value;
            }
            set
            {
                tag_value = value;
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

        public TagBriefInfo(string name, string value)
        {
            this.name = name;
            this.tag_value = value;
        }
    }
}
