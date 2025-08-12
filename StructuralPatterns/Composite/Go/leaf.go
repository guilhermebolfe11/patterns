package main

import "fmt"

type Leaf struct {
	name string
}

func NewLeaf(name string) *Leaf {
	return &Leaf{name: name}
}

func (l *Leaf) Operation() {
	fmt.Printf("Leaf: %s\n", l.name)
}
