export class Singleton {
    private static instance: Singleton;
    private constructor() {
    }

    public static getInstance(): Singleton {
        if (!Singleton.instance) {
            Singleton.instance = new Singleton();
        }
        return Singleton.instance;
    }

    public someBusinessLogic(): void {
        console.log('Executando lógica de negócio do Singleton!');
    }
}

