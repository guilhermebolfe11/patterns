package main

type SubsystemB struct{}

func (s *SubsystemB) OperationB() string {
	return "SubsystemB: Go!"
}
