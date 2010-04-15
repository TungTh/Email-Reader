using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Operator;

namespace EmailReader.View
{
    class OperationBriefInfo
    {
        string name;
        IOperator ope;
        
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


        public override string ToString()
        {
            return name;
        }

        public IOperator getOperator()
        {
            return this.ope;
        }

        public OperationBriefInfo(IOperator ope)
        {
            this.name = ope.Name;
            this.ope = ope;
        }
    }
}
