using EncapsulationExample;

//Создание объекта кота
Cat cat = new Cat("Барсик");
Console.WriteLine($"Создан кот {cat.Name}");

//Накормить объект кота
cat.Feed(new Food("Fish"));

//Накормить объект кота
cat.Feed(new Food("Vegetables"));
