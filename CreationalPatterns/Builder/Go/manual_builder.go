package main

type ManualBuilder struct {
	manual *Manual
}

func (b *ManualBuilder) Reset() {
	b.manual = &Manual{}
}

func (b *ManualBuilder) SetSeats(seats int) {
	b.manual.Seats = seats
}

func (b *ManualBuilder) SetEngine(engine string) {
	b.manual.Engine = engine
}

func (b *ManualBuilder) SetTripComputer(hasTripComputer bool) {
	b.manual.TripComputer = hasTripComputer
}

func (b *ManualBuilder) SetGPS(hasGPS bool) {
	b.manual.GPS = hasGPS
}

func (b *ManualBuilder) GetResult() *Manual {
	return b.manual
}
