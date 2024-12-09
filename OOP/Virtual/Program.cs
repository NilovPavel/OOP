using Virtual;

Animal animal = new Animal();
Console.WriteLine($"Animal {animal.Name} speach:");
animal.Speak();

//Console.WriteLine("\nDog speach:");
Animal dog = new Dog();
Console.WriteLine($"\nAnimal {dog.Name} speach:");
dog.Speak();

Wolf wolf = new Wolf();
Console.WriteLine($"\nAnimal {wolf.Name} speach:");
wolf.Speak();