import { Notifier } from './Notifier';

export class PushNotifier implements Notifier {
    send(message: string): void {
        console.log(`Sending PUSH: ${message}`);
    }
}

