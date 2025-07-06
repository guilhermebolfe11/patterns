import { NotificationCreator } from './NotificationCreator';
import { Notifier } from './Notifier';
import { EmailNotifier } from './EmailNotifier';

export class EmailNotificationCreator extends NotificationCreator {
  factoryMethod(): Notifier {
    return new EmailNotifier();
  }
}

