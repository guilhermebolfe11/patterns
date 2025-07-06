using System;

namespace FactoryMethod {
    public class EmailNotifier : INotifier {
        public void Send(string message) {
            Console.WriteLine($"Sending EMAIL notification: {message}");
        }
    }
}

