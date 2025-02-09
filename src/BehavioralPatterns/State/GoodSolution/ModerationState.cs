namespace ConsoleApp1.src.BehavioralPatterns.State.GoodSolution
{
    public class ModerationState : IState
    {
        private Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            if (_document.CurrentUserRole == UserRoles.Admin)
            {
                _document.State = new PublishedState(_document);
            }
        }
    }
}