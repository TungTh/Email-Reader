using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  public class StringContainsOperator : IOperator
  {
    #region IOperator Members

    public string Name
    {
      get { return "String contains operator"; }
    }

    public bool validateInput(string value, string criteria)
    {
      return true;
    }

    public bool apply(string value, string criteria)
    {
      return value.Contains(criteria);
    }

    #endregion
  }
}
