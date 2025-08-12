package main

import "fmt"

func clientCode(target Target) {
	fmt.Println(target.Request())
}

func main() {
	fmt.Println("Client: I can work just fine with the Target objects:")
	target := TargetFunc(func() string {
		return "Target: The default target's behavior."
	})
	clientCode(target)

	fmt.Println()

	adaptee := &Adaptee{}
	fmt.Println("Client: The Adaptee class has a weird interface. See, I don't understand it:")
	fmt.Printf("Adaptee: %s\n", adaptee.SpecificRequest())

	fmt.Println()

	fmt.Println("Client: But I can work with it via the Adapter:")
	adapter := NewAdapter(adaptee)
	clientCode(adapter)
}

type TargetFunc func() string

func (f TargetFunc) Request() string {
	return f()
}
