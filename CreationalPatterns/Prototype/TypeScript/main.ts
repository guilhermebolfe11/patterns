import { Circle } from './Circle';
import { Rectangle } from './Rectangle';
import { Shape } from './Shape';

const shapes: Shape[] = [];

const circle = new Circle();
circle.x = 10;
circle.y = 20;
circle.color = 'Red';
circle.radius = 15;
shapes.push(circle);

const anotherCircle = circle.clone();
anotherCircle.color = 'Blue';
shapes.push(anotherCircle);

const rectangle = new Rectangle();
rectangle.x = 5;
rectangle.y = 7;
rectangle.color = 'Green';
rectangle.width = 30;
rectangle.height = 40;
shapes.push(rectangle);

const anotherRectangle = rectangle.clone();
anotherRectangle.width = 50;
shapes.push(anotherRectangle);

for (const shape of shapes) {
    console.log(shape.toString());
}

