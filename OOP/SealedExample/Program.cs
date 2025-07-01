// Sealed-класс
/*sealed*/ class ParentSealed
{}

class ChildSealed : ParentSealed
{ }


//sealed-метод
class Animal
{
    public virtual void Speak() { }
}

class Dog : Animal
{
    // Метод переопределен и запечатан (sealed)
    public /*sealed*/ override void Speak() { }
}

// Попытка переопределения метода приведет к ошибке
class Bulldog : Dog
{
    // Ошибка компиляции! Speak запечатан в Dog.
    public override void Speak() { }
}