using System;
using System.Collections.Generic;

namespace Composite {
    public class Composite : IComponent {
        private string name;
        private List<IComponent> children = new List<IComponent>();
        public Composite(string name) {
            this.name = name;
        }
        public void Add(IComponent child) {
            children.Add(child);
        }
        public void Remove(IComponent child) {
            children.Remove(child);
        }
        public void Operation() {
            Console.WriteLine($"Composite: {name}");
            foreach (var child in children) {
                child.Operation();
            }
        }
    }
}

