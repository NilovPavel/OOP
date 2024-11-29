// See https://aka.ms/new-console-template for more information

List<string> strings = new List<string>() { "1", "2" };

List<int> ints = new List<int>() { 1, 2, 3 };

strings.ForEach
    (
        item => Console.WriteLine(item)
    );

ints.ForEach
    (
        item => Console.WriteLine(item)
    );