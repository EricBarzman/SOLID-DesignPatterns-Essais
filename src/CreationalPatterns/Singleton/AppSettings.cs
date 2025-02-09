namespace ConsoleApp1.src.CreationalPatterns.Singleton
{
    public class AppSettings
    {
        private Dictionary<string, object> _settings = new Dictionary<string, object>();

        // Here, the singleton lines
        private static AppSettings _instance;

        private AppSettings() {}

        public static AppSettings getInstance() {
            if (_instance == null)
                _instance = new AppSettings();
            return _instance;
        }

        

        public object Get(string key) {
            if (!_settings.ContainsKey(key))
                return null;

            return _settings[key];
        }

        public void Set(string key, object value) {
            _settings[key] = value;
        }
    }
}