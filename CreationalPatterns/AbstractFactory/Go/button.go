package main

import "fmt"

type Button interface {
	Paint()
}

type WinButton struct{}

func (b *WinButton) Paint() {
	fmt.Println("Render a button in Windows style.")
}

type MacButton struct{}

func (b *MacButton) Paint() {
	fmt.Println("Render a button in MacOS style.")
}
