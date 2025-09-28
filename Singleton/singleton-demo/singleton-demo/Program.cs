namespace singleton_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance1 = President.GetInstance("anzor");
            var instance2 = President.GetInstance("kakha"); // will NOT create a new
                                                            // instance
            Console.WriteLine("Are instances the same? " + (instance1 == instance2));
            Console.WriteLine("President's name: " + instance1.name);
            Console.WriteLine("President's name: " + instance2.name);
        }
    }
}