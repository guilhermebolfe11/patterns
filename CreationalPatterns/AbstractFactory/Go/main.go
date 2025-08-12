package main

import "fmt"

func getFactory(os string) GUIFactory {
	if os == "Windows" {
		return &WinFactory{}
	} else {
		return &MacFactory{}
	}
}

func main() {
	os := "Windows"

	factory := getFactory(os)
	button := factory.CreateButton()
	checkbox := factory.CreateCheckbox()

	fmt.Println("--- GUI Components ---")
	button.Paint()
	checkbox.Paint()
}
