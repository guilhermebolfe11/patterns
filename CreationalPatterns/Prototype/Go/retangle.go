package main

import "fmt"

type Rectangle struct {
    X, Y, Width, Height int
    Color               string
}

func (r *Rectangle) Clone() Shape {
    return &Rectangle{
        X:      r.X,
        Y:      r.Y,
        Width:  r.Width,
        Height: r.Height,
        Color:  r.Color,
    }
}

func (r *Rectangle) ToString() string {
    return fmt.Sprintf("Rectangle: x=%d, y=%d, color=%s, width=%d, height=%d", r.X, r.Y, r.Color, r.Width, r.Height)
}