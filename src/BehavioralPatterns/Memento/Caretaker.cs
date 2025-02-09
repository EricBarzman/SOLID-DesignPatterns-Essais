namespace ConsoleApp1.src.BehavioralPatterns.Memento
{
    public class Caretaker
    {
        private List<EditorState> _states = new List<EditorState>();
        private Editor _editor;

        public Caretaker(Editor editor)
        {
            _editor = editor;
        }

        public void Backup()
        {
            _states.Add(_editor.CreateState());
        }

        public void Undo()
        {
            if (_states.Count() == 0)
                return;

            // Prendre le dernier
            EditorState prevState = _states.Last();
            // Le retirer de la liste
            _states.Remove(prevState);
            // Le restorer
            _editor.Restore(prevState);
        }

        public void ShowHistory()
        {
            System.Console.WriteLine("\nHistory: Here is the list of mementos:");
            foreach (var state in _states)
            {
                System.Console.WriteLine(state.GetName());
            }
        }
    }
}