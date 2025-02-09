namespace ConsoleApp1.src.BehavioralPatterns.Memento
{
    // Memento Object
    public class EditorState
    {
        private readonly string _title;
        private readonly string _content;
        // State metadata
        private readonly DateTime _stateCreatedAt;

        public EditorState(string title, string content)
        {
            _title = title;
            _content = content;
            _stateCreatedAt = DateTime.Now;
        }

        public string GetTitle()
        {
            return _title;
        }
        public string GetContent()
        {
            return _content;
        }

        public DateTime GetDate()
        {
            return _stateCreatedAt;
        }

        public string GetName()
        {
            return $"{_stateCreatedAt} / {_title}";
        }
    }
}