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
            int newPos = heap.Count;

            // 1. Add a node for the new element into the left - most empty slot in the lowest level of the tree
            heap.Add(s);

            // 2. If the new node is the root of the tree, or the value of the new node is smaller than or equal to its parent, stop the algorithm
            while (!(newPos == 0 || String.Compare(s,heap[(newPos-1)/2]) >= 0))
            {
                // 3. Swap the node with its parent and go back to Step 2
                string temp = heap[(newPos - 1) / 2];
                heap[(newPos - 1) /2] = s;
                heap[newPos] = temp;
                newPos = (newPos - 1) / 2;
            }


        }

        public string Remove()
        {
            string topOfHeap = heap[0];
            heap.RemoveAt(0);
            return topOfHeap;
        }
    }
}
