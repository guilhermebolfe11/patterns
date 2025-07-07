import { GUIFactory } from './GUIFactory';
import { Button } from './Button';
import { Checkbox } from './Checkbox';
import { WinButton } from './WinButton';
import { WinCheckbox } from './WinCheckbox';

export class WinFactory implements GUIFactory {
    createButton(): Button {
        return new WinButton();
    }
    createCheckbox(): Checkbox {
        return new WinCheckbox();
    }
}