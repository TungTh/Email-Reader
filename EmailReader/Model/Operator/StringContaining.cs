using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Operator
{
  public class StringContaining : IOperator
  {
    static IOperator _operator = null;

    public static IOperator getInstance()
    {
      if (_operator == null)
        _operator = new StringContaining();
      return _operator;
    }

    private StringContaining() { }

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
  }
}
