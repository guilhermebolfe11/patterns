import { Notifier } from './Notifier';

export class EmailNotifier implements Notifier {
  send(message: string): void {
    console.log(`Sending EMAIL notification: ${message}`);
  }
}

