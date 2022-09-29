using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExample
{
    public class Heap<T> where T : IComparable
    {
        List<T> heap = new List<T>();

        public void Insert(T s)
        {
            Debug.Assert ( s != null );
            int newPos = heap.Count;

            // 1. Add a node for the new element into the left - most empty slot in the lowest level of the tree
            heap.Add(s);

            // 2. If the new node is the root of the tree, or the value of the new node is larger than or equal to its parent, stop the algorithm
            while (!(newPos == 0 || s.CompareTo(heap[(newPos-1)/2]) >= 0))
            {
                // 3. Swap the node with its parent and go back to Step 2
                T temp = heap[(newPos - 1) / 2];
                heap[(newPos - 1) /2] = s;
                heap[newPos] = temp;
                newPos = (newPos - 1) / 2;
            }


        }

        public T Remove()
        {
            // If the heap is empty, return a null string
            if (heap.Count == 0) return default(T);

            T topOfHeap = heap[0];

            // 1. Replace the root node by the right-most node at the bottom level of the tree
            T migratedNode = heap[heap.Count - 1];
            heap[0] = migratedNode;
            int newPos = 0;
            while (true)
            {
                int leftChildPos = newPos * 2 + 1;
                int rightChildPos = newPos * 2 + 2;

                // 2. If the migrated node is smaller or equal to all of its successor nodes, stop the algorithm
                int greatestSuccessorPos = 0;
                // if there are no successor nodes, stop
                if (leftChildPos >= heap.Count) break;
                // if there is only a left successor, then if it is larger, stop
                if (rightChildPos >= heap.Count)
                {
                    if (heap[leftChildPos].CompareTo(migratedNode) >= 0) break;
                    greatestSuccessorPos = leftChildPos;
                }
                else
                {
                    // If there are two successors, check which is smaller first.
                    greatestSuccessorPos = heap[leftChildPos].CompareTo( heap[rightChildPos]) < 0 ? leftChildPos : rightChildPos;
                    if (heap[greatestSuccessorPos].CompareTo( migratedNode) >= 0) break;
                }
                // 3. Swap the migrated node with its smallest successor and go back to Step 2
                T greatestSuccessor = heap[greatestSuccessorPos];
                heap[newPos] = greatestSuccessor;
                heap[greatestSuccessorPos] = migratedNode;
                newPos = greatestSuccessorPos;
            }

            heap.RemoveAt(heap.Count - 1);
            return topOfHeap;
        }
    }
}
