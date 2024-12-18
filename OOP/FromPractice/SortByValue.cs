// See https://aka.ms/new-console-template for more information
internal class SortByValue : ISort
{
    public Element[] Sort(Element[] elements)
    {
        Array.Sort(elements, (item1, item2) => item1.Value.CompareTo(item2.Value));
        return elements;
    }
}