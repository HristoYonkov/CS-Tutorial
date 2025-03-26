namespace MyApp
{
    public class DoublyLinkedList<T>
    {
        private LinkedListItem<T> first = null;
        private LinkedListItem<T> last = null;

        public int Count { get; private set; }
        // read-only property (have only get method)
        public int Count2
        {
            get
            {
                var count = 0;
                var current = first;

                while (current != null)
                {
                    count++;
                    current = current.Next;
                }

                return count;
            }
        }

        // Adds an element at the beginning of the collection
        public void AddFirst(T element)
        {
            var newItem = new LinkedListItem<T>(element);
            if (first == null)
            {
                first = newItem;
                last = newItem;
            }
            else
            {
                newItem.Next = first;
                first.Previous = newItem;
                first = newItem;
            }

            Count++;
        }

        // Adds an element at the end of the collection
        public void AddLast(T element)
        {
            var newItem = new LinkedListItem<T>(element);
            if (last == null)
            {
                first = newItem;
                last = newItem;
            }
            else
            {
                last.Next = newItem;
                newItem.Previous = last;
                last = newItem;
            }

            Count++;
        }

        // Removes the element at the beginning of the collection
        public T RemoveFirst()
        {
            if (first == null) // 0 items
            {
                throw new InvalidOperationException("Linked list empty!");
            }

            T currentFirstValue = first.Value;

            if (first == last) // 1 item
            {
                first = null;
                last = null;
            }
            else // more than 1 item
            {
                var newFirst = first.Next;
                newFirst.Previous = null;
                first = newFirst;
            }

            Count--;
            return currentFirstValue;
        }

        // Removes the element at the end of the collection
        public T RemoveLast()
        {
            if (last == null) // 0 items
            {
                throw new InvalidOperationException("Linked list empty!");
            }

            T currentLastValue = first.Value;

            if (last == first) // 1 item
            {
                last = null;
                first = null;
            }
            else // more than 1 item
            {
                var newLast = last.Previous;
                newLast.Next = null;
                last = newLast;
            }

            Count--;
            return currentLastValue;
        }

        // Goes through the collection and executes a given action
        public void ForEach(Action<T> action)
        {
            var current = first;
            while (current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }

        // Returns the collection as an array
        public T[] ToArray()
        {
            var array = new T[Count2];
            var current = first;

            var index = 0;
            while (current != null)
            {
                array[index] = current.Value;
                current = current.Next;
                index++;
            }
            return array;
        }
    }
}
