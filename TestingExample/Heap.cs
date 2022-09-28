using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExample
{
    public class Heap
    {
        List<string> heap = new List<string>();

        public void Insert(string s)
        {
            heap.Add(s);
        }

        public string Remove()
        {
            string topOfHeap = heap[0];
            heap.RemoveAt(0);
            return topOfHeap;
        }
    }
}
