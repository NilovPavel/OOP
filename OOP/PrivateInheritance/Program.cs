
class Parent
{
    private int secret = 42;

    protected int GetSecret() => secret;
}

class Child : Parent
{
    public void ShowSecret()
    {
        // ❌ Ошибка компиляции: 'secret' недоступен
        //Console.WriteLine(secret); 
    }

    public void RevealSecret()
    {
        Console.WriteLine($"Inherited secret: {GetSecret()}");
    }
}