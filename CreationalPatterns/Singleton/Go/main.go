package main

import "fmt"

func main() {
    singleton1 := GetInstance()
    singleton2 := GetInstance()

    if singleton1 == singleton2 {
        fmt.Println("singleton1 e singleton2 são a mesma instância.")
    } else {
        fmt.Println("singleton1 e singleton2 são instâncias diferentes.")
    }

    singleton1.SomeBusinessLogic()
}