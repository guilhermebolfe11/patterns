package main

import "fmt"

type Circle struct {
    X, Y, Radius int
    Color        string
}

func (c *Circle) Clone() Shape {
    return &Circle{
        X:      c.X,
        Y:      c.Y,
        Radius: c.Radius,
        Color:  c.Color,
    }
}

func (c *Circle) ToString() string {
    return fmt.Sprintf("Circle: x=%d, y=%d, color=%s, radius=%d", c.X, c.Y, c.Color, c.Radius)
}