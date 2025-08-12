package main

type Facade struct {
	a *SubsystemA
	b *SubsystemB
	c *SubsystemC
}

func NewFacade(a *SubsystemA, b *SubsystemB, c *SubsystemC) *Facade {
	return &Facade{
		a: a,
		b: b,
		c: c,
	}
}

func (f *Facade) Operation() string {
	result := "Facade initializes subsystems:\n"
	result += f.a.OperationA() + "\n"
	result += f.b.OperationB() + "\n"
	result += f.c.OperationC() + "\n"
	result += "Facade orders subsystems to perform the action:"
	return result
}
