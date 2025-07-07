import { NotifierDecorator } from './NotifierDecorator';

export class LoggingDecorator extends NotifierDecorator {
    send(message: string): void {
        console.log(`[LOG] Sending notification: ${message}`);
        super.send(message);
    }
}

