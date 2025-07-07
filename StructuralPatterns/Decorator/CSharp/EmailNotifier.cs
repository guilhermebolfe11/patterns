namespace Decorator {
    public class EmailNotifier : INotifier {
        public void Send(string message) {
            System.Console.WriteLine($"Sending EMAIL: {message}");
        }
    }
}

