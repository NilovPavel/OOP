using Abstract;

//Экземпляр абстрактного класса не может быть создан
/*Animal animal = new Animal("Кот");
animal.MakeSound();*/

Animal animal = new Cat("Кот");
animal.MakeSound();