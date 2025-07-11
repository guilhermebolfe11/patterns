using System;

namespace FacadeExample {
    class Program {
        static void Main(string[] args) {
            var facade = new Facade();
            Console.WriteLine(facade.Operation());
        }
    }
}

