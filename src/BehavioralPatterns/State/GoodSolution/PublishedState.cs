namespace ConsoleApp1.src.BehavioralPatterns.State.GoodSolution
{
    public class PublishedState : IState
    {
        private Document _document;

        public PublishedState(Document document)
        {
            _document = document;
        }

        // Do nothing if already in published state
        public void Publish() { }
    }
}