import { Shape } from './Shape';

export class Circle extends Shape {
    radius: number = 0;

    constructor(source?: Circle) {
        super(source);
        if (source) {
            this.radius = source.radius;
        }
    }

    clone(): Circle {
        return new Circle(this);
    }

    toString(): string {
        return `Circle: x=${this.x}, y=${this.y}, color=${this.color}, radius=${this.radius}`;
    }
}

