namespace ConsoleApp1.src.BehavioralPatterns.Command.undoable
{
    public class HtmlDocument
    {
        public string Content { get; set;}
        
        public void MakeItalic() {
            Content = "<i>" + Content + "</i>";
        }
    }
}