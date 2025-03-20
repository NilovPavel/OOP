using Virtual;

// 1. Вызов метода из родителя (поведение по умолчанию)
Animal animal = new Animal();
Console.WriteLine($"Animal {animal.Name} speach:");
animal.Speak();

// 2. Вызов метода дочернего класса без переопределения метода, но с переопределенным свойством
Animal dog = new Dog();
Console.WriteLine($"\nAnimal {dog.Name} speach:");
// 2.' Раскомментировать метод в классе Dog
dog.Speak();

// 3. Вызов метода дочернего класса c переопределения метода b свойства
Animal wolf = new Wolf();
Console.WriteLine($"\nAnimal {wolf.Name} speach:");
wolf.Speak();