import { Button } from './Button';

export class MacButton implements Button {
    paint(): void {
        console.log('Render a button in MacOS style.');
    }
}

