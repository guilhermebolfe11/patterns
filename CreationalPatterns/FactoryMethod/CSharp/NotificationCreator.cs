namespace FactoryMethod {
    public abstract class NotificationCreator {
        // Factory Method
        public abstract INotifier FactoryMethod();

        // Core logic that uses the Notifier
        public void Send(string message) {
            var notifier = FactoryMethod();
            notifier.Send(message);
        }
    }
}

