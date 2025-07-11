using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new LoggingDecorator(new FormattingDecorator(new EmailNotifier()));
            var sms = new FormattingDecorator(new SMSNotifier());
            var push = new LoggingDecorator(new PushNotifier());
            email.Send("Hello via Email");
            sms.Send("Hello via SMS");
            push.Send("Hello via Push");
        }
    }
}
