using System;
using WhatIsInheritance;

//Создание животного
Animal anyAnimal = new Animal();

Console.WriteLine(anyAnimal.GetName());

Cat murka = new Cat("Мурка");
murka.GetName();

Console.WriteLine(murka.GetName());

Tiger tiger = new Tiger();
Console.WriteLine(tiger.GetName());

