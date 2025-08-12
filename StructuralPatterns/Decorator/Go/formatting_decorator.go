package main

import (
	"fmt"
	"strings"
)

type FormattingDecorator struct {
	NotifierDecorator
}

func NewFormattingDecorator(notifier Notifier) *FormattingDecorator {
	return &FormattingDecorator{NotifierDecorator{wrapped: notifier}}
}

func (d *FormattingDecorator) Send(message string) {
	formatted := fmt.Sprintf("*** %s ***", strings.ToUpper(message))
	d.wrapped.Send(formatted)
}
