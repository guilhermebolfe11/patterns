package main

type CarBuilder struct {
	car *Car
}

func (b *CarBuilder) Reset() {
	b.car = &Car{}
}

func (b *CarBuilder) SetSeats(seats int) {
	b.car.Seats = seats
}

func (b *CarBuilder) SetEngine(engine string) {
	b.car.Engine = engine
}

func (b *CarBuilder) SetTripComputer(hasTripComputer bool) {
	b.car.TripComputer = hasTripComputer
}

func (b *CarBuilder) SetGPS(hasGPS bool) {
	b.car.GPS = hasGPS
}

func (b *CarBuilder) GetResult() *Car {
	return b.car
}
