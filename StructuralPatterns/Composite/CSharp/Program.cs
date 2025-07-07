using System;

namespace Composite {
    class Program {
        static void Main(string[] args) {
            var root = new Composite("root");
            var branch1 = new Composite("branch1");
            var branch2 = new Composite("branch2");

            var leaf1 = new Leaf("leaf1");
            var leaf2 = new Leaf("leaf2");
            var leaf3 = new Leaf("leaf3");

            branch1.Add(leaf1);
            branch1.Add(leaf2);
            branch2.Add(leaf3);
            root.Add(branch1);
            root.Add(branch2);

            root.Operation();
        }
    }
}

