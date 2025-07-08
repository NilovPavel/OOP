using EncapsulationExample;
using EncapsulationExtLibrary;

//Создание объекта кота
Cat cat = new Cat("Барсик");

//Доступ к публичному свойству
Console.WriteLine($"Создан кот {cat.Name}");

//Раскомментировать
//cat.DigestFood(new Food("Fish"));

//Накормить объект кота
//Доступ к публичному методу
//Внутри будем обращаться к приватному методу
cat.Feed(new Food("Fish"));

//Накормить объект кота (непригодной пищей) 
cat.Feed(new Food("Vegetables"));

//Создание объекта животного с модификатором доступа public из сборки EncapsulationExtLibrary, слинкованной в проект
Animal animal = new Animal();

//Попытка создать объект собаки с модификатором доступа internal из сборки EncapsulationExtLibrary, слинкованной в проект
Animal dog = new Dog();
//dog.SayHello();