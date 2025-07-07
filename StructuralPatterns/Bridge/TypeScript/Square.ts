import { Shape } from './Shape';
import { Renderer } from './Renderer';

export class Square extends Shape {
    private readonly size: number;
    constructor(renderer: Renderer, size: number) {
        super(renderer);
        this.size = size;
    }
    draw(): void {
        this.renderer.renderSquare(this.size);
    }
}

