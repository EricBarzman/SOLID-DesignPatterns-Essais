namespace ConsoleApp1.src.BehavioralPatterns.Memento
{
    // Originator
    public class Editor
    {
        public string title { get; set; }
        public string content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(title, content);
        }

        public void Restore(EditorState state)
        {
            title = state.GetTitle();
            content = state.GetContent();
        }
    }
}