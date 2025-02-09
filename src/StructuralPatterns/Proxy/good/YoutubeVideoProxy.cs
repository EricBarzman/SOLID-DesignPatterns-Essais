namespace ConsoleApp1.src.StructuralPatterns.Proxy.good
{
    public class YoutubeVideoProxy : Video
    {
        private string _videoId;
        private YoutubeVideo _youtubeVideo;

        public YoutubeVideoProxy(string videoId)
        {
            _videoId = videoId;
        }

        public string GetVideoId()
        {
            return _videoId;
        }

        // Lazy rendering
        public void Render()
        {
            if (_youtubeVideo == null)
                _youtubeVideo = new YoutubeVideo(_videoId);

            _youtubeVideo.Render();
        }
    }
}