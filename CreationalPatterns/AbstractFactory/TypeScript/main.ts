import { GUIFactory } from './GUIFactory';
import { WinFactory } from './WinFactory';
import { MacFactory } from './MacFactory';

function getFactory(os: string): GUIFactory {
    if (os === 'Windows') {
        return new WinFactory();
    } else {
        return new MacFactory();
    }
}

const os =  'Windows';
//const os =  'Mac';
const factory = getFactory(os);
const button = factory.createButton();
const checkbox = factory.createCheckbox();
button.paint();
checkbox.paint();

