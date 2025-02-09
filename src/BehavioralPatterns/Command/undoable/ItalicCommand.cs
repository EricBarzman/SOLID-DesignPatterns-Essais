namespace ConsoleApp1.src.BehavioralPatterns.Command.undoable
{
    public class ItalicCommand : IUndoableCommand
    {
        private HtmlDocument _doc;
        private string _prevContent = "";
        private History _history;

        public ItalicCommand(HtmlDocument doc, History history) {
            _doc = doc;
            _history = history;
        }

        public void Execute()
        {
            _prevContent = _doc.Content;
            _doc.MakeItalic(); // delegating this to the doc business object
            _history.Push(this);
        }

        public void Unexecute()
        {
            _doc.Content = _prevContent;
        }
    }
}