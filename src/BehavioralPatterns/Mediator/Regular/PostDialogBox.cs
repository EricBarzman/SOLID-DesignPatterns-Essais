namespace ConsoleApp1.src.BehavioralPatterns.Mediator.Regular
{
    public class PostDialogBox : DialogBox
    {
        // Fields for all UI components
        private ListBox _postsListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public PostDialogBox() {
            _postsListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);
            _saveButton.SetIsEnabled(false);
        }

        public void SimulateUserInteraction() {
            _postsListBox.SetSelection("Post 2");
            _titleTextBox.SetText("");
            System.Console.WriteLine("Title text box: " + _titleTextBox.GetText());
            System.Console.WriteLine("Button enabled: " + _saveButton.IsEnabled());
        }

        public override void Changed(UIControl uiControl)
        {
            if (uiControl == _postsListBox)
                HandlePostChanged();

            if (uiControl == _titleTextBox)
                HandleTitleChanged();
        }

        private void HandlePostChanged() {
            _titleTextBox.SetText(_postsListBox.GetSelection());
            _saveButton.SetIsEnabled(true);
        }

        private void HandleTitleChanged() {
            bool isTitleEmpty = _titleTextBox.GetText() == "";
            _saveButton.SetIsEnabled(!isTitleEmpty);
        }
    }
}