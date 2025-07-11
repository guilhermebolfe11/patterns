import { Target } from './Target';
import { Adaptee } from './Adaptee';
import { Adapter } from './Adapter';

function clientCode(target: Target) {
    console.log(target.request());
}

console.log('Client: I can work just fine with the Target objects:');
const target: Target = {
    request: () => "Target: The default target's behavior."
};
clientCode(target);

console.log('');

const adaptee = new Adaptee();
console.log("Client: The Adaptee class has a weird interface. See, I don't understand it:");
console.log(`Adaptee: ${adaptee.specificRequest()}`);

console.log('');

console.log('Client: But I can work with it via the Adapter:');
const adapter = new Adapter(adaptee);
clientCode(adapter);
