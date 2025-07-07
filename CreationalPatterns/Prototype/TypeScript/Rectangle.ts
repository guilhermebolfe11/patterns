import { Shape } from './Shape';

export class Rectangle extends Shape {
    width: number = 0;
    height: number = 0;

    constructor(source?: Rectangle) {
        super(source);
        if (source) {
            this.width = source.width;
            this.height = source.height;
        }
    }

    clone(): Rectangle {
        return new Rectangle(this);
    }

    toString(): string {
        return `Rectangle: x=${this.x}, y=${this.y}, color=${this.color}, width=${this.width}, height=${this.height}`;
    }
}

