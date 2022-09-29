// See https://aka.ms/new-console-template for more information
using TestingExample;

Heap<string> heap = new Heap<string>();

heap.Insert("a");
heap.Insert("c");
heap.Insert("b");
string output;
// Print sorted input:

while (heap.Count > 0)
{
    output = heap.Remove();
    Console.WriteLine(output);
}


