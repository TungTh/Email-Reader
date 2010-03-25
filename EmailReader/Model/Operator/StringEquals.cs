using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Operator
{
  public class StringEquals : EmailReader.Model.IOperator
  {
    static IOperator _operator = null;

    public static IOperator getInstance()
    {
      if (_operator == null)
        _operator = new StringEquals();
      return _operator;
    }

    private StringEquals() { }

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
  }
}
