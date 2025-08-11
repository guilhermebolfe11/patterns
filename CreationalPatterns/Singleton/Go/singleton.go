package main

import (
	"fmt"
	"sync"
)

type singleton struct {
}

func (s *singleton) SomeBusinessLogic() {
    fmt.Println("Executando lógica de negócio do Singleton!")
}

var instance *singleton
var once sync.Once

func GetInstance() *singleton {
    once.Do(func() {
        instance = &singleton{}
    })
    return instance
}