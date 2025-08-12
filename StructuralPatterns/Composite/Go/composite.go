package main

import "fmt"

type Composite struct {
	name     string
	children []Component
}

func NewComposite(name string) *Composite {
	return &Composite{name: name}
}

func (c *Composite) Add(child Component) {
	c.children = append(c.children, child)
}

func (c *Composite) Remove(child Component) {
	for i, comp := range c.children {
		if comp == child {
			c.children = append(c.children[:i], c.children[i+1:]...)
			break
		}
	}
}

func (c *Composite) Operation() {
	fmt.Printf("Composite: %s\n", c.name)
	for _, child := range c.children {
		child.Operation()
	}
}
