using EncapsulationExample;

Cat cat = new Cat("Барсик");
Console.WriteLine($"Создан кот {cat.Name}");

cat.Feed(new Food("Fish"));
cat.Feed(new Food("Vegetables"));
