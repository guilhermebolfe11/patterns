package main

import "fmt"

type Manual struct {
	Seats        int
	Engine       string
	TripComputer bool
	GPS          bool
}

func (m *Manual) ToString() string {
	return fmt.Sprintf("Manual: Seats: %d, Engine: %s, TripComputer: %t, GPS: %t", m.Seats, m.Engine, m.TripComputer, m.GPS)
}
