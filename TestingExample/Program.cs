// See https://aka.ms/new-console-template for more information
using TestingExample;

Heap heap = new Heap();

heap.Insert("a");
heap.Insert("c");
heap.Insert("b");
Console.WriteLine(heap.Remove());

