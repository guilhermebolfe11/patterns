package main

type Circle struct {
	renderer Renderer
	radius   float64
}

func NewCircle(renderer Renderer, radius float64) *Circle {
	return &Circle{renderer: renderer, radius: radius}
}

func (c *Circle) Draw() {
	c.renderer.RenderCircle(c.radius)
}
