import { Notifier } from './Notifier';

export abstract class NotificationCreator {
  // Factory Method
  abstract factoryMethod(): Notifier;

  // Core logic that uses the Notifier
  send(message: string): void {
    const notifier = this.factoryMethod();
    notifier.send(message);
  }
}

