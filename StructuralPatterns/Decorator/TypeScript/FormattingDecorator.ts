import { NotifierDecorator } from './NotifierDecorator';

export class FormattingDecorator extends NotifierDecorator {
    send(message: string): void {
        const formatted = `*** ${message.toUpperCase()} ***`;
        super.send(formatted);
    }
}

