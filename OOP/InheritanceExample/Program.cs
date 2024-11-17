//Наследование от примитивных типов данных 

interface I
{ }

struct A : I
{ }

struct B : I
{ }

enum C : byte
{
    eA = 0, eB = 1,
    eC = 255
}

class User
{
}

class Admin : User
{ }