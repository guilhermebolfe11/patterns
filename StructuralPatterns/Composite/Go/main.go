package main

func main() {
	root := NewComposite("root")
	branch1 := NewComposite("branch1")
	branch2 := NewComposite("branch2")

	leaf1 := NewLeaf("leaf1")
	leaf2 := NewLeaf("leaf2")
	leaf3 := NewLeaf("leaf3")

	branch1.Add(leaf1)
	branch1.Add(leaf2)
	branch2.Add(leaf3)
	root.Add(branch1)
	root.Add(branch2)

	root.Operation()
}
