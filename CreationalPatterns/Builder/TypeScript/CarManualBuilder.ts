import { Builder } from './Builder';
import { Manual } from './Manual';

export class CarManualBuilder implements Builder {
    private manual: Manual = new Manual();

    reset(): void {
        this.manual = new Manual();
    }
    setSeats(seats: number): void {
        this.manual.seats = seats;
    }
    setEngine(engine: string): void {
        this.manual.engine = engine;
    }
    setTripComputer(hasTripComputer: boolean): void {
        this.manual.tripComputer = hasTripComputer;
    }
    setGPS(hasGPS: boolean): void {
        this.manual.gps = hasGPS;
    }
    getResult(): Manual {
        return this.manual;
    }
}

