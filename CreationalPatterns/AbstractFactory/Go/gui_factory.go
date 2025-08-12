package main

type GUIFactory interface {
	CreateButton() Button
	CreateCheckbox() Checkbox
}
