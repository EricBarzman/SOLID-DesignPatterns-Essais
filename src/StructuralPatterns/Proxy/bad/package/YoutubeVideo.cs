namespace ConsoleApp1.src.StructuralPatterns.Proxy.bad
{
    public class YoutubeVideo : Video
    {
        private string _videoId;

        public YoutubeVideo(string videoId) {
            _videoId = videoId;
            Download();
        }

        private void Download() {
            System.Console.WriteLine("Downloading video with ID: " + _videoId + " from Youtube API");
        }

        public void Render()
        {
            System.Console.WriteLine("Rendering video with ID: " + _videoId);
        }

        public string GetVideoId()
        {
            return _videoId;
        }
    }
}