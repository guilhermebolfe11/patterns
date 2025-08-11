package main

type Shape interface {
	Clone() Shape
	ToString() string
}