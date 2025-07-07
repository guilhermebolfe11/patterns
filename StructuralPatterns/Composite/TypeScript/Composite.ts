import { Component } from './Component';

export class Composite implements Component {
    private readonly name: string;
    private children: Component[] = [];
    constructor(name: string) {
        this.name = name;
    }
    add(child: Component): void {
        this.children.push(child);
    }
    remove(child: Component): void {
        this.children = this.children.filter(c => c !== child);
    }
    operation(): void {
        console.log(`Composite: ${this.name}`);
        for (const child of this.children) {
            child.operation();
        }
    }
}

