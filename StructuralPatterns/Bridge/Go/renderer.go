package main

import "fmt"

type Renderer interface {
	RenderCircle(radius float64)
	RenderSquare(size float64)
}

type VectorRenderer struct{}

func (v *VectorRenderer) RenderCircle(radius float64) {
	fmt.Printf("Drawing a circle of radius %.2f with vector renderer.\n", radius)
}

func (v *VectorRenderer) RenderSquare(size float64) {
	fmt.Printf("Drawing a square of size %.2f with vector renderer.\n", size)
}

type RasterRenderer struct{}

func (r *RasterRenderer) RenderCircle(radius float64) {
	fmt.Printf("Drawing a circle of radius %.2f with raster renderer.\n", radius)
}

func (r *RasterRenderer) RenderSquare(size float64) {
	fmt.Printf("Drawing a square of size %.2f with raster renderer.\n", size)
}
