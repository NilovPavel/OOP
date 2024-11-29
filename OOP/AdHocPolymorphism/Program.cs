// See https://aka.ms/new-console-template for more information
using AdHocPolymorphism;


AdHoc adHoc = new AdHoc();

decimal a = adHoc.Add(1, 2);
Console.WriteLine(a);

string  b = adHoc.Add("1", "2");
Console.WriteLine(b);