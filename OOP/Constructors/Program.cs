class Animal
{
    //Конструктор без параметров
    public Animal() { }

    // Конструктор с параметром
    public Animal(string name){ }
}

class Dog : Animal
{
    // Конструктор Dog ОБЯЗАН вызвать конструктор базового класса
    public Dog(string name) : base(name) {  /*to do*/  }
}

class Cat : Animal
{
    public Cat(string name) { } // : base() {    }
}