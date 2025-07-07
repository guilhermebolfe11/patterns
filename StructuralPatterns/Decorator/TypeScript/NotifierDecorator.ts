import { Notifier } from './Notifier';

export class NotifierDecorator implements Notifier {
    protected wrapper: Notifier;
    constructor(wrapper: Notifier) {
        this.wrapper = wrapper;
    }
    send(message: string): void {
        this.wrapper.send(message);
    }
}

