import { SubsystemA } from './SubsystemA';
import { SubsystemB } from './SubsystemB';
import { SubsystemC } from './SubsystemC';

export class Facade {
    private a: SubsystemA;
    private b: SubsystemB;
    private c: SubsystemC;

    constructor(a?: SubsystemA, b?: SubsystemB, c?: SubsystemC) {
        this.a = a || new SubsystemA();
        this.b = b || new SubsystemB();
        this.c = c || new SubsystemC();
    }

    operation(): string {
        let result = 'Facade initializes subsystems:\n';
        result += this.a.operationA() + '\n';
        result += this.b.operationB() + '\n';
        result += this.c.operationC() + '\n';
        result += 'Facade orders subsystems to perform the action:';
        return result;
    }
}

