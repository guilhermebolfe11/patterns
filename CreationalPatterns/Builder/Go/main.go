package main

import "fmt"

func main() {
	director := &Director{}

	carBuilder := &CarBuilder{}
	director.ConstructSportsCar(carBuilder)
	car := carBuilder.GetResult()
	fmt.Println("Car built:", car.ToString())

	manualBuilder := &ManualBuilder{}
	director.ConstructSUV(manualBuilder)
	manual := manualBuilder.GetResult()
	fmt.Println("Manual built:", manual.ToString())
}
