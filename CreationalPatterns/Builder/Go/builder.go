package main

type Builder interface {
	Reset()
	SetSeats(seats int)
	SetEngine(engine string)
	SetTripComputer(hasTripComputer bool)
	SetGPS(hasGPS bool)
}
