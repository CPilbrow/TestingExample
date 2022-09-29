// See https://aka.ms/new-console-template for more information
using TestingExample;

Heap heap = new Heap();

heap.Insert("a");
heap.Insert("c");
heap.Insert("b");
heap.Insert(null);
string output;
// Print sorted input:
while ((output = heap.Remove()) != null)
{
    Console.WriteLine(output);
}


