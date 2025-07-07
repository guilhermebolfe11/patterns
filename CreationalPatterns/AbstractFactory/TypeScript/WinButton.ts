import { Button } from "./Button";

export class WinButton implements Button {
    paint(): void {
        console.log('Render a button in Windows style.');
    }
}