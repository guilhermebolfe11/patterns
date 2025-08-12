package main

import "fmt"

func clientCode(facade *Facade) {
	fmt.Println(facade.Operation())
}

func main() {
	a := &SubsystemA{}
	b := &SubsystemB{}
	c := &SubsystemC{}

	facade := NewFacade(a, b, c)
	clientCode(facade)
}
