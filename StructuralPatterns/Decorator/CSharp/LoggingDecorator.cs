namespace Decorator {
    public class LoggingDecorator : NotifierDecorator {
        public LoggingDecorator(INotifier wrapper) : base(wrapper) {}
        public override void Send(string message) {
            System.Console.WriteLine($"[LOG] Sending notification: {message}");
            base.Send(message);
        }
    }
}

