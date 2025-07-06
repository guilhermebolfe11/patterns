using System;

namespace FactoryMethod {
    public class SMSNotifier : INotifier {
        public void Send(string message) {
            Console.WriteLine($"Sending SMS notification: {message}");
        }
    }
}

