// See https://aka.ms/new-console-template for more information
internal class SortByName : ISort
{
    public Element[] Sort(Element[] elements)
    {
        Array.Sort(elements, (item1, item2) => item1.Name.CompareTo(item2.Name));
        return elements;
    }
}