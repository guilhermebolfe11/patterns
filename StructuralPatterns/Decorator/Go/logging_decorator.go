package main

import "fmt"

type LoggingDecorator struct {
	NotifierDecorator
}

func NewLoggingDecorator(notifier Notifier) *LoggingDecorator {
	return &LoggingDecorator{NotifierDecorator{wrapped: notifier}}
}

func (d *LoggingDecorator) Send(message string) {
	fmt.Printf("[LOG] Sending notification: %s\n", message)
	d.wrapped.Send(message)
}
