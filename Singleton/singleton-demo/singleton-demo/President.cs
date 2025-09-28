namespace singleton_demo
{
    public class President
    {
        public string name;
        private static President? _instance;
        private static readonly object _lock = new object();
        // Private constructor to prevent instantiation
        // from outside
        private President() { }
        public static President GetInstance(string name)
        {
            if (_instance == null)
            {
                lock (_lock) // makes sure onlyone thread at a 
                             // time can enter that code block.
                {
                    if (_instance == null)
                    {
                        _instance = new President();
                        _instance.name = name;
                    }
                }
            }
            return _instance;
        }
    }
}