import { Director } from './Director';
import { CarBuilder } from './CarBuilder';
import { CarManualBuilder } from './CarManualBuilder';

const director = new Director();
const carBuilder = new CarBuilder();
director.constructSportsCar(carBuilder);
const car = carBuilder.getResult();
console.log('Car built:', car.toString());

const manualBuilder = new CarManualBuilder();
director.constructSUV(manualBuilder);
const manual = manualBuilder.getResult();
console.log('Manual built:', manual.toString());

