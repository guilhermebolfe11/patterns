export class Car {
    seats: number = 0;
    engine: string = '';
    tripComputer: boolean = false;
    gps: boolean = false;

    toString(): string {
        return `Seats: ${this.seats}, Engine: ${this.engine}, TripComputer: ${this.tripComputer}, GPS: ${this.gps}`;
    }
}

