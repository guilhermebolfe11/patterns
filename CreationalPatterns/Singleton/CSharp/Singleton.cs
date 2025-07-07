using System;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("Executando lógica de negócio do Singleton!");
        }
    }
}
