using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model.Command
{
  public class ActionHandler : EmailReader.Model.Command.IActionHandler
  {
    Stack<IAction> _Undo = new Stack<IAction>();
    Stack<IAction> _Redo = new Stack<IAction>();
    ReverseOrderMacro _Macro = new ReverseOrderMacro();
    bool _IsUndoing = false;
    bool _IsRedoing = false;

    int _NumOfEndMacroNeeded = 0;
    public bool CanUndo
    {
      get { return _Undo.Count != 0; }
    }

    public bool CanRedo
    {
      get { return _Redo.Count != 0; }
    }

    public ActionHandler()
    {
    }

    public void beginMacro()
    {      
      if (_NumOfEndMacroNeeded++ == 0) _Macro = new ReverseOrderMacro();
      System.Diagnostics.Debug.WriteLine("Begin " + _NumOfEndMacroNeeded.ToString());
    }
    public void endMacro()
    {
      System.Diagnostics.Debug.WriteLine("End " + _NumOfEndMacroNeeded.ToString());
      System.Diagnostics.Debug.Assert(_NumOfEndMacroNeeded > 0);
      if (--_NumOfEndMacroNeeded == 0)
        storeAction(_Macro);
    }

    public void storeAction(IAction action)
    {
      System.Diagnostics.Debug.WriteLine("Store: " + action.ToString());

      if (!_IsRedoing && !_IsUndoing) _Redo.Clear();

      if (_NumOfEndMacroNeeded > 0)
        _Macro.Add(action);
      else if (_IsUndoing) _Redo.Push(action);
      else _Undo.Push(action);
    }

    public void undo()
    {
      System.Diagnostics.Debug.WriteLine("---- Undo ---");
      System.Diagnostics.Debug.Assert(_NumOfEndMacroNeeded == 0, "EndMacro is expected");
      if (_Undo.Count > 0)
      {
        _IsUndoing = true;
        excuteAction(_Undo.Pop());
        _IsUndoing = false;
      }
    }
    public void redo()
    {
      System.Diagnostics.Debug.WriteLine("---- Redo ---");

      System.Diagnostics.Debug.Assert(_NumOfEndMacroNeeded == 0, "EndMacro is expected");
      if (_Redo.Count > 0)
      {
        _IsRedoing = true;
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
