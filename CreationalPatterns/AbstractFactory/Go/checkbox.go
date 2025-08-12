package main

import "fmt"

type Checkbox interface {
	Paint()
}

type WinCheckbox struct{}

func (c *WinCheckbox) Paint() {
	fmt.Println("Render a checkbox in Windows style.")
}

type MacCheckbox struct{}

func (c *MacCheckbox) Paint() {
	fmt.Println("Render a checkbox in MacOS style.")
}
