package main

import "fmt"

type Notifier interface {
	Send(message string)
}

type SMSNotifier struct{ Notifier }

func (s *SMSNotifier) Send(message string) {
	fmt.Printf("Sending SMS notification: %s\n", message)
}

type EmailNotifier struct{ Notifier }

func (e *EmailNotifier) Send(message string) {
	fmt.Printf("Sending EMAIL notification: %s\n", message)
}
