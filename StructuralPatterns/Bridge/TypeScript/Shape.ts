import { Renderer } from './Renderer';

export abstract class Shape {
    protected renderer: Renderer;
    protected constructor(renderer: Renderer) {
        this.renderer = renderer;
    }
    abstract draw(): void;
}

