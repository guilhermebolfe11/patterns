package main

func main() {
	vector := &VectorRenderer{}
	raster := &RasterRenderer{}

	circle := NewCircle(vector, 5)
	circle.Draw()

	square := NewSquare(raster, 10)
	square.Draw()
}
