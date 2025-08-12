package main

func main() {
	email := NewLoggingDecorator(NewFormattingDecorator(&EmailNotifier{}))
	sms := NewFormattingDecorator(&SMSNotifier{})
	push := NewLoggingDecorator(&PushNotifier{})

	email.Send("Hello via Email")
	sms.Send("Hello via SMS")
	push.Send("Hello via Push")
}
