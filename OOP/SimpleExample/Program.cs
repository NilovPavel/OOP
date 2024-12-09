using SimpleExample;

//1. Раскомментировать для демонстрации

//Ошибка компиляции
//ISoldier iSoldier = new ISoldier();

//Ошибка компиляции
//Human human = new Human();

//2. Создание объекта сапера
ISoldier soldier = new Sapper("Иванов");

//Выполнить реализованный у сапера метод
soldier.ToDo();

//3. Вызвать метод, реализованный в интерфейсе
soldier.SubmitRapport();

//4. Реализованный интерфейсный метод можно переопределить в классе
Sapper sapper2 = new Sapper("Петров");

//Для демонстрации раскомментировать метод SubmitRapport у класса сапера
//sapper2.SubmitRapport();

//5. Демонстрация вызова метода "просто идти" человека
((Human)soldier).JustGo();

//6. Демонстрация dynamic (возможно не нужно показывать)
/*dynamic sapper3 = new Sapper("Сидоров");
sapper3.SubmitRapport();*/