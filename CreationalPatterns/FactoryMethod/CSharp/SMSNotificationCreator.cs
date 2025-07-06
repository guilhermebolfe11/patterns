namespace FactoryMethod {
    public class SMSNotificationCreator : NotificationCreator {
        public override INotifier FactoryMethod() {
            return new SMSNotifier();
        }
    }
}

