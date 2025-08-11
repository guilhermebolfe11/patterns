package main

import "fmt"

func clientCode(creator NotificationCreator, message string) {
    creator.Send(message)
}

func main() {
    emailCreator := &EmailNotificationCreator{}
    smsCreator := &SMSNotificationCreator{}

    fmt.Println("--- Email Notification ---")
    clientCode(emailCreator, "Hello via Email!")

    fmt.Println("--- SMS Notification ---")
    clientCode(smsCreator, "Hello via SMS!")
}