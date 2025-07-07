import { Prototype } from './Prototype';

export abstract class Shape implements Prototype<Shape> {
    x: number = 0;
    y: number = 0;
    color: string = '';

    protected constructor(source?: Shape) {
        if (source) {
            this.x = source.x;
            this.y = source.y;
            this.color = source.color;
        }
    }

    abstract clone(): Shape;
}

