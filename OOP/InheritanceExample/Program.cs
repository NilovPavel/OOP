using NotInheritanceSpace;

//2

Console.WriteLine("Вызов без параметра в конструкторе");
new TryInheritance();

Console.WriteLine("\nВызов конструктора с 1 параметром");

new TryInheritance(1);

Console.WriteLine("\nВызов конструктора с 2-мя параметрами");
new TryInheritance(2,2);
;

//3 
//Попытка вызвать статичный метод
Console.WriteLine("\nВызов статичного метода");
TryInheritance.StaticMethod();          //обращение идет к NotInheritance
Console.WriteLine("\nВызов статичной переменной");
Console.WriteLine(TryInheritance.a);    //обращение идет также к NotInheritance

//4
//Обращение к
