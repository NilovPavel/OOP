public class Coder
{
    private string name;
    private string salary;

    public string Name => this.name; 

    public string Salary
    {
        get { return this.salary; }
        set { this.salary = value; }
    }

    public string GetName()
    {
        return this.name;
    }

    public void WriteCode()
    {
        Console.WriteLine("I'm coding!");
    }

    public Coder(string name)
    { this.name = name; }

    public Coder() { }
}