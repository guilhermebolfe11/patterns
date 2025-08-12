package main

type NotifierDecorator struct {
	wrapped Notifier
}

func (d *NotifierDecorator) Send(message string) {
	d.wrapped.Send(message)
}
