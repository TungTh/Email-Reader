using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  public class ActionHandle
  {
    static Stack<IAction> _Undo = new Stack<IAction>();
    static Stack<IAction> _Redo = new Stack<IAction>();
    static Stack<ReverseOrderMacro> _MacroStack = new Stack<ReverseOrderMacro>();
    bool _IsUndoing = false;
    bool _IsRedoing = false;

    public bool CanUndo
    {
      get { return _Undo.Count != 0; }
    }

    public ActionHandle()
    {
    }

    public void BeginMacro()
    {
      _MacroStack.Push(new ReverseOrderMacro());
    }
    public void EndMacro()
    {
      System.Diagnostics.Debug.Assert(_MacroStack.Count > 0);
      StoreAction(_MacroStack.Pop());
    }

    public void StoreAction(IAction action)
    {
      // must implement clear redo stack
      if (!_IsRedoing && !_IsUndoing) _Redo.Clear();

      if (_MacroStack.Count > 0)
        _MacroStack.Peek().Add(action);
      else if (_IsUndoing) _Redo.Push(action);
      else _Undo.Push(action);
    }

    public void Undo()
    {
      System.Diagnostics.Debug.Assert(_MacroStack.Count == 0, "EndMacro is expected");
      if (_Undo.Count > 0)
      {
        System.Diagnostics.Debug.WriteLine("");
        _IsUndoing = true;
        ExcuteAction(_Undo.Pop());
        _IsUndoing = false;
      }
    }
    public void Redo()
    {
      System.Diagnostics.Debug.Assert(_MacroStack.Count == 0, "EndMacro is expected");
      if (_Redo.Count > 0)
      {
        _IsRedoing = true;
        System.Diagnostics.Debug.WriteLine("");
        ExcuteAction(_Redo.Pop());
        _IsRedoing = false;
      }
    }

    private void ExcuteAction(IAction action)
    {
      if (action is ReverseOrderMacro)
      {
        BeginMacro();
        action.Execute();
        EndMacro();
      }
      else action.Execute();
    }
  }
}
