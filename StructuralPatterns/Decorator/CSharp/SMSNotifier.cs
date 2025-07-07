namespace Decorator {
    public class SMSNotifier : INotifier {
        public void Send(string message) {
            System.Console.WriteLine($"Sending SMS: {message}");
        }
    }
}

