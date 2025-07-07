import { Checkbox } from './Checkbox';

export class WinCheckbox implements Checkbox {
    paint(): void {
        console.log('Render a checkbox in Windows style.');
    }
}