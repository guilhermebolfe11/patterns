using System;

namespace Composite {
    public class Leaf : IComponent {
        private string name;
        public Leaf(string name) {
            this.name = name;
        }
        public void Operation() {
            Console.WriteLine($"Leaf: {name}");
        }
    }
}

