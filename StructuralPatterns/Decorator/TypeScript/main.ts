import { EmailNotifier } from './EmailNotifier';
import { SMSNotifier } from './SMSNotifier';
import { PushNotifier } from './PushNotifier';
import { LoggingDecorator } from './LoggingDecorator';
import { FormattingDecorator } from './FormattingDecorator';

const email = new LoggingDecorator(new FormattingDecorator(new EmailNotifier()));
const sms = new FormattingDecorator(new SMSNotifier());
const push = new LoggingDecorator(new PushNotifier());

email.send('Hello via Email');
sms.send('Hello via SMS');
push.send('Hello via Push');

