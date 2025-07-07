import { Component } from './Component';

export class Leaf implements Component {
    private readonly name: string;
    constructor(name: string) {
        this.name = name;
    }
    operation(): void {
        console.log(`Leaf: ${this.name}`);
    }
}

