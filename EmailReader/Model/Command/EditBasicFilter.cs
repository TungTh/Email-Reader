using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Operator;
namespace EmailReader.Model.Command
{
  class EditBasicFilter:IAction
  {
    string _newName;
    ITag _newTag;
    string _newCriteria;
    BasicFilter _target;
    IOperator _newOperator;

    internal EditBasicFilter(BasicFilter target, string newName, ITag newTag, IOperator newOperator, string newCriteria)
    {
      _newName = newName;
      _newTag = newTag;
      _newCriteria = newCriteria;
      _target = target;
      _newOperator = newOperator;

    }

    public void execute()
    {
      _target.edit(_newName, _newTag, _newOperator, _newCriteria);
    }
  }
}
