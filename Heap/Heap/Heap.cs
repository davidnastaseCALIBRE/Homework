using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeapAssignment
{
    /// <summary>
    /// Remember, no Lists, Arrays, Collections.
    /// This is a Data Structure that helps keep track of the highest
    /// value in a set of data only, you should be using recursion to handle this.
    /// Use wikipedia or other online resources as needed to get an idea of the
    /// basic structure of a Heap.
    /// </summary>
    public class Heap
    {
        /// <summary>
        /// Creates a new, empty Heap object for use.
        /// </summary>
        public Heap()
        {
        }

        /// <summary>
        /// Adds the specified int to the Heap.
        /// A value should replace a parent node if it exceeds its value, in which case
        /// the old parent becomes a child node.
        /// If the value is smaller than the Parent node, it should fill the first blank
        /// child opening on the parent.
        /// If no child nodes are available, send it to be inserted to one of the child
        /// nodes as appropriate.
        /// </summary>
        /// <param name="add">The value to be added.</param>
        public void Insert(int add)
        {

        }

        /// <summary>
        /// Returns the Highest Value from the Heap without altering
        /// the state of the Heap.
        /// </summary>
        /// <returns>The current highest value in the heap</returns>
        public int PeakMax()
        {
            return 0;
        }

        /// <summary>
        /// Returns the largest value from the Heap, and also
        /// removes that value from the heap.
        /// </summary>
        /// <returns></returns>
        public int ExtractMax()
        {
            return 0;
        }

        /// <summary>
        /// Returns the number of elements added to the heap.
        /// </summary>
        /// <returns>The number of Elements in the Heap.</returns>
        public int Size()
        {
            return 0;
        }

        /// <summary>
        /// Returns a new heap that is a combination of this heap and
        /// the received heap. Both original heaps are preserved, and
        /// unmodified.
        /// </summary>
        /// <param name="other"></param>
        public Heap Merge(Heap other)
        {
            return null;
        }

        /// <summary>
        /// Empties the current Heap of all values.
        /// </summary>
        public void Empty()
        {

        }
    }
}
