using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  public class ActionHandler
  {
    static Stack<IAction> _Undo = new Stack<IAction>();
    static Stack<IAction> _Redo = new Stack<IAction>();
    ReverseOrderMacro _Macro = new ReverseOrderMacro();
    bool _IsUndoing = false;
    bool _IsRedoing = false;

    int _NumOfEndMacroNeeded = 0;
    public bool CanUndo
    {
      get { return _Undo.Count != 0; }
    }

    public ActionHandler()
    {
    }

    public void beginMacro()
    {
      if (_NumOfEndMacroNeeded++ == 0) _Macro = new ReverseOrderMacro();
    }
    public void endMacro()
    {
      System.Diagnostics.Debug.Assert(_NumOfEndMacroNeeded > 0);
      if (--_NumOfEndMacroNeeded == 0)
        storeAction(_Macro);
    }

    public void storeAction(IAction action)
    {
      if (!_IsRedoing && !_IsUndoing) _Redo.Clear();

      if (_NumOfEndMacroNeeded > 0)
        _Macro.Add(action);
      else if (_IsUndoing) _Redo.Push(action);
      else _Undo.Push(action);
    }

    public void undo()
    {
      System.Diagnostics.Debug.Assert(_NumOfEndMacroNeeded == 0, "EndMacro is expected");
      if (_Undo.Count > 0)
      {
        System.Diagnostics.Debug.WriteLine("");
        _IsUndoing = true;
        excuteAction(_Undo.Pop());
        _IsUndoing = false;
      }
    }
    public void redo()
    {
      System.Diagnostics.Debug.Assert(_NumOfEndMacroNeeded == 0, "EndMacro is expected");
      if (_Redo.Count > 0)
      {
        _IsRedoing = true;
        System.Diagnostics.Debug.WriteLine("");
        excuteAction(_Redo.Pop());
        _IsRedoing = false;
      }
    }

    private void excuteAction(IAction action)
    {
      if (action is ReverseOrderMacro)
      {
        beginMacro();
        action.execute();
        endMacro();
      }
      else action.execute();
    }
  }
}
