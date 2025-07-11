namespace FacadeExample {
    public class Facade {
        private readonly SubsystemA a;
        private readonly SubsystemB b;
        private readonly SubsystemC c;

        public Facade(SubsystemA a = null, SubsystemB b = null, SubsystemC c = null) {
            this.a = a ?? new SubsystemA();
            this.b = b ?? new SubsystemB();
            this.c = c ?? new SubsystemC();
        }

        public string Operation() {
            var result = "Facade initializes subsystems:\n";
            result += this.a.OperationA() + "\n";
            result += this.b.OperationB() + "\n";
            result += this.c.OperationC() + "\n";
            result += "Facade orders subsystems to perform the action:";
            return result;
        }
    }
}

