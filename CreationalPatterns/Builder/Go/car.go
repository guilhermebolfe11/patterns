package main

import "fmt"

type Car struct {
	Seats        int
	Engine       string
	TripComputer bool
	GPS          bool
}

func (c *Car) ToString() string {
	return fmt.Sprintf("Seats: %d, Engine: %s, TripComputer: %t, GPS: %t", c.Seats, c.Engine, c.TripComputer, c.GPS)
}
