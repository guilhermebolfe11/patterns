import { Checkbox } from './Checkbox';

export class MacCheckbox implements Checkbox {
    paint(): void {
        console.log('Render a checkbox in MacOS style.');
    }
}

