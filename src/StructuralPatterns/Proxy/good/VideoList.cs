namespace ConsoleApp1.src.StructuralPatterns.Proxy.good
{
    public class VideoList
    {
        private Dictionary<string, Video> _videoList = new();

        public void Add(Video video) {
            _videoList.Add(video.GetVideoId(), video);
        }

        public void Watch(string videoId) {
            var video = _videoList[videoId];
            video.Render();
        }
    }
}