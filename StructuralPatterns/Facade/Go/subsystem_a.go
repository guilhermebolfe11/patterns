package main

type SubsystemA struct{}

func (s *SubsystemA) OperationA() string {
	return "SubsystemA: Ready!"
}
