public class Coder
{
    private string name;
    private string salary;

    public string Name
    { get { return this.name; } }

    public void WriteCode()
    {
        Console.WriteLine("I'm coding!");
    }

    public Coder(string name)
    { this.name = name; }

    public Coder() { }
}