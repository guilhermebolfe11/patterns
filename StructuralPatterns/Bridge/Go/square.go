package main

type Square struct {
	renderer Renderer
	size     float64
}

func NewSquare(renderer Renderer, size float64) *Square {
	return &Square{renderer: renderer, size: size}
}

func (s *Square) Draw() {
	s.renderer.RenderSquare(s.size)
}
