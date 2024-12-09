using Base;

Console.WriteLine("Вызов метода дочернего класса");
new DerivedClass().SomeMethod();

Console.WriteLine("\nВызов конструктора без параметров");
new DerivedClass();

Console.WriteLine("\nВызов конструктора с int параметром");
new DerivedClass(1);

Console.WriteLine("\nВызов конструктора с string параметром");
new DerivedClass("2");