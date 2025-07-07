import { Renderer } from './Renderer';

export class VectorRenderer implements Renderer {
    renderCircle(radius: number): void {
        console.log(`Drawing a circle of radius ${radius} with vector renderer.`);
    }
    renderSquare(size: number): void {
        console.log(`Drawing a square of size ${size} with vector renderer.`);
    }
}

