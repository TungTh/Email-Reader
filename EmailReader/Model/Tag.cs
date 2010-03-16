using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;
namespace EmailReader.Model
{
    public class Tag : TagSubject
    {
        public Tag(string name, bool isDefault)
        {
            base(name, isDefault);
        }
      
    }
}

