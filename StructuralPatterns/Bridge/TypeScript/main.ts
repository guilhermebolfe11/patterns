import { VectorRenderer } from './VectorRenderer';
import { RasterRenderer } from './RasterRenderer';
import { Circle } from './Circle';
import { Square } from './Square';

const vector = new VectorRenderer();
const raster = new RasterRenderer();

const circle = new Circle(vector, 5);
circle.draw();

const square = new Square(raster, 10);
square.draw();

