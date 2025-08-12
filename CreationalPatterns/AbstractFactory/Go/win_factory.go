package main

type WinFactory struct{}

func (f *WinFactory) CreateButton() Button {
	return &WinButton{}
}

func (f *WinFactory) CreateCheckbox() Checkbox {
	return &WinCheckbox{}
}
