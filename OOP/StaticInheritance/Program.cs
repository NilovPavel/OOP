Derived.SayHello(); // Hello from Derived
Base.SayHello();    // Hello from Base

class Base
{
    public static void SayHello()
    {
        Console.WriteLine("Hello from Base");
    }
}

class Derived : Base
{
    public static void SayHello()
    {
        Console.WriteLine("Hello from Derived");
    }
}