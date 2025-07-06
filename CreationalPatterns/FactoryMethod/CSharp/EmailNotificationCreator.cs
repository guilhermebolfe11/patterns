namespace FactoryMethod {
    public class EmailNotificationCreator : NotificationCreator {
        public override INotifier FactoryMethod() {
            return new EmailNotifier();
        }
    }
}

