import { Shape } from './Shape';
import { Renderer } from './Renderer';

export class Circle extends Shape {
    private readonly radius: number;
    constructor(renderer: Renderer, radius: number) {
        super(renderer);
        this.radius = radius;
    }
    draw(): void {
        this.renderer.renderCircle(this.radius);
    }
}

