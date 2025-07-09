//Animal animal = new Animal();

Animal dog = new Dog();
dog.Speak();    // Выведет: Собака лает

// Абстрактный класс: нельзя создать экземпляр, только наследовать
abstract class Animal
{
    // Абстрактный метод — без реализации
    public abstract void Speak();
}

// Конкретный класс, реализующий абстракцию
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Собака лает");
    }
}