package main

import "fmt"

func main() {
    var shapes []Shape

    circle := &Circle{
        X:      10,
        Y:      20,
        Color:  "Red",
        Radius: 15,
    }
    shapes = append(shapes, circle)

    anotherCircle := circle.Clone().(*Circle)
    anotherCircle.Color = "Blue"
    shapes = append(shapes, anotherCircle)

    rectangle := &Rectangle{
        X:      5,
        Y:      7,
        Color:  "Green",
        Width:  30,
        Height: 40,
    }
    shapes = append(shapes, rectangle)

    anotherRectangle := rectangle.Clone().(*Rectangle)
    anotherRectangle.Width = 50
    shapes = append(shapes, anotherRectangle)

    for _, shape := range shapes {
        fmt.Println(shape.ToString())
    }
}