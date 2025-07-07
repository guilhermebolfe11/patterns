import { Renderer } from './Renderer';

export class RasterRenderer implements Renderer {
    renderCircle(radius: number): void {
        console.log(`Drawing a circle of radius ${radius} with raster renderer.`);
    }
    renderSquare(size: number): void {
        console.log(`Drawing a square of size ${size} with raster renderer.`);
    }
}

