package main

type NotificationCreator interface {
	FactoryMethod() Notifier
	Send(message string)
}

type SMSNotificationCreator struct{}

func (s *SMSNotificationCreator) FactoryMethod() Notifier {
	return &SMSNotifier{}
}

func (s *SMSNotificationCreator) Send(message string) {
	notifier := s.FactoryMethod()
	notifier.Send(message)
}

type EmailNotificationCreator struct{}

func (e *EmailNotificationCreator) FactoryMethod() Notifier {
	return &EmailNotifier{}
}

func (e *EmailNotificationCreator) Send(message string) {
	notifier := e.FactoryMethod()
	notifier.Send(message)
}
