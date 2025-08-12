package main

import "fmt"

type Notifier interface {
	Send(message string)
}

type EmailNotifier struct{}

func (e *EmailNotifier) Send(message string) {
	fmt.Printf("Sending EMAIL: %s\n", message)
}

type SMSNotifier struct{}

func (s *SMSNotifier) Send(message string) {
	fmt.Printf("Sending SMS: %s\n", message)
}

type PushNotifier struct{}

func (p *PushNotifier) Send(message string) {
	fmt.Printf("Sending PUSH: %s\n", message)
}
