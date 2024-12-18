// See https://aka.ms/new-console-template for more information

ISort sort = null;

Element[] elements = new Element[]
    {
        new Element{ Name = "1", Value = 2 }
        , new Element{ Name = "3", Value = 0 }
    };


int a = 1;



switch (a)
{ 
    case 0:
        sort = new SortByValue();
        break;
    case 1:
        sort = new SortByName();
        break;
}

Element[] sortElements = sort.Sort(elements);

Array.ForEach(sortElements, item => Console.WriteLine($"{item.Name} - {item.Value}"));
;