namespace ConsoleApp1.src.BehavioralPatterns.Command.undoable
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}