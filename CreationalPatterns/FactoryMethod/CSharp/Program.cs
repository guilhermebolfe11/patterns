using System;

namespace FactoryMethod {
    class Program {
        static void ClientCode(NotificationCreator creator, string message) {
            creator.Send(message);
        }

        static void Main(string[] args) {
            var emailCreator = new EmailNotificationCreator();
            var smsCreator = new SMSNotificationCreator();

            Console.WriteLine("--- Email Notification ---");
            ClientCode(emailCreator, "Hello via Email!");

            Console.WriteLine("--- SMS Notification ---");
            ClientCode(smsCreator, "Hello via SMS!");
        }
    }
}
