//IAnimal animal = new IAnimal();

IAnimal dog = new Dog();
dog.Speak();    // Выведет: Собака лает

// Интерфейс
interface IAnimal
{
    // Метод интерфейса. В классическом случае - без реализации
    void Speak();
}

// Конкретный класс, реализующий интерфейс
class Dog : IAnimal
{
    // Явная реализация метода
    /*void IAnimal.Speak()
    {
        throw new NotImplementedException();
    }*/

    // Неявная реализация метода
    public void Speak()
    {
        throw new NotImplementedException();
    }
}