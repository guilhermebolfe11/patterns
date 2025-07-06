import { EmailNotificationCreator } from './EmailNotificationCreator';
import { SMSNotificationCreator } from './SMSNotificationCreator';
import { NotificationCreator } from './NotificationCreator';

function clientCode(creator: NotificationCreator, message: string) {
  creator.send(message);
}

const emailCreator = new EmailNotificationCreator();
const smsCreator = new SMSNotificationCreator();

console.log('--- Email Notification ---');
clientCode(emailCreator, 'Hello via Email!');

console.log('--- SMS Notification ---');
clientCode(smsCreator, 'Hello via SMS!');

