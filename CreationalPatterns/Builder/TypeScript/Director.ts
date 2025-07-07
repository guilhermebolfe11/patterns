import { Builder } from './Builder';

export class Director {
    constructSportsCar(builder: Builder): void {
        builder.reset();
        builder.setSeats(2);
        builder.setEngine('V8');
        builder.setTripComputer(true);
        builder.setGPS(true);
    }

    constructSUV(builder: Builder): void {
        builder.reset();
        builder.setSeats(7);
        builder.setEngine('V6');
        builder.setTripComputer(false);
        builder.setGPS(true);
    }
}

