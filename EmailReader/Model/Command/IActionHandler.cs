using System;
namespace EmailReader.Model.Command
{
  public interface IActionHandler
  {
    void beginMacro();
    bool CanUndo { get; }
    bool CanRedo { get; }
    void endMacro();
    void redo();
    void storeAction(IAction action);
    void undo();
  }
}
