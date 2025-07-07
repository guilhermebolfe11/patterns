namespace Decorator {
    public class PushNotifier : INotifier {
        public void Send(string message) {
            System.Console.WriteLine($"Sending PUSH: {message}");
        }
    }
}

