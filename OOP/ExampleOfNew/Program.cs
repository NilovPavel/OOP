Animal animal = new Dog();
animal.Speak(); // Выведет: Animal.Speak()

Dog animal2 = new Dog();
animal2.Speak(); // Выведет: Base.Speak()    

class Animal
{
    public void Speak() =>
        Console.WriteLine("Animal speaks");
}

class Dog : Animal
{
    public new void Speak() =>
        Console.WriteLine("Dog barks");
}
