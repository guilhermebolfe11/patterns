import { Builder } from './Builder';
import { Car } from './Car';

export class CarBuilder implements Builder {
    private car: Car = new Car();

    reset(): void {
        this.car = new Car();
    }
    setSeats(seats: number): void {
        this.car.seats = seats;
    }
    setEngine(engine: string): void {
        this.car.engine = engine;
    }
    setTripComputer(hasTripComputer: boolean): void {
        this.car.tripComputer = hasTripComputer;
    }
    setGPS(hasGPS: boolean): void {
        this.car.gps = hasGPS;
    }
    getResult(): Car {
        return this.car;
    }
}

