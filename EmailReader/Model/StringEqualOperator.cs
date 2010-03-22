using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  public class StringEqualOperator : EmailReader.Model.IOperator
  {
    #region IOperator Members

    public string Name
    {
      get { return "String equal operator"; }
    }

    public bool validateInput(string value, string criteria)
    {
      return true;
    }

    public bool apply(string value, string criteria)
    {
      return value == criteria;
    }

    #endregion
  }
}
