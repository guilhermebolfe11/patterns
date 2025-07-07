using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singleton.Instance;
            var singleton2 = Singleton.Instance;
            Console.WriteLine($"singleton1 == singleton2: {singleton1 == singleton2}");
            singleton1.SomeBusinessLogic();
        }
    }
}

