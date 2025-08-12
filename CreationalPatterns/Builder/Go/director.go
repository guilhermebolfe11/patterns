package main

type Director struct{}

func (d *Director) ConstructSportsCar(builder Builder) {
	builder.Reset()
	builder.SetSeats(2)
	builder.SetEngine("V8")
	builder.SetTripComputer(true)
	builder.SetGPS(true)
}

func (d *Director) ConstructSUV(builder Builder) {
	builder.Reset()
	builder.SetSeats(7)
	builder.SetEngine("V6")
	builder.SetTripComputer(false)
	builder.SetGPS(true)
}
