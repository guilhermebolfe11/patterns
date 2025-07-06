import { Notifier } from './Notifier';

export class SMSNotifier implements Notifier {
  send(message: string): void {
    console.log(`Sending SMS notification: ${message}`);
  }
}

