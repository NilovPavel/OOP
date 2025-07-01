using Virtual;

// 1. Вызов метода из родителя (поведение по умолчанию)
Animal animal = new Animal();
Console.WriteLine($"Animal {animal.Name} speach:");
animal.Speak();
