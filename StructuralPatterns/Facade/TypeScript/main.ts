import { Facade } from './Facade';

function clientCode(facade: Facade) {
    console.log(facade.operation());
}

const facade = new Facade();
clientCode(facade);

