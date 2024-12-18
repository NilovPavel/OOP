// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

internal interface ISort
{
    Element[] Sort(Element[] elements);
}