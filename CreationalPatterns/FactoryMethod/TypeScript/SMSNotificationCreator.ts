import { NotificationCreator } from './NotificationCreator';
import { Notifier } from './Notifier';
import { SMSNotifier } from './SMSNotifier';

export class SMSNotificationCreator extends NotificationCreator {
  factoryMethod(): Notifier {
    return new SMSNotifier();
  }
}

