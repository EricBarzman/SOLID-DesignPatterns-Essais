namespace ConsoleApp1.src.BehavioralPatterns.Mediator.WithObserver
{
    public class PostsDialogBox
    {
        // Declare field for components
        private ListBox _postsListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public PostsDialogBox() {
            _postsListBox = new ListBox();
            _titleTextBox = new TextBox();
            _saveButton = new Button();

            _postsListBox.AddEventHandler(PostSelected);
            _titleTextBox.AddEventHandler(TitleSelected);
        }

        private void PostSelected() {
            _titleTextBox.SetText(_postsListBox.GetSelection());
            _saveButton.SetIsEnabled(true);
        }

        private void TitleSelected() {
            bool isTitleEmpty = _titleTextBox.GetText() == "";
            _saveButton.SetIsEnabled(!isTitleEmpty);
        }

    }
}