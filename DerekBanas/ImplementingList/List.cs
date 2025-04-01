
namespace CustomList
{
    internal class List
    {
        private const int Defaultcapacity = 2;
        private int[] items;
        public int Count { get; set; }
        public int this[int i] // Following property is example of indexer in C#
        {
            get {
                IsInRange(i);
                return items[i];
            }
            set {
                IsInRange(i);
                items[i] = value;
            }
        }
        public List()
        {
            items = new int[Defaultcapacity];
        }
        public void Add(int element)
        {
            if (Count == items.Length)
            {
                int[] tempArray = new int[items.Length * 2];

                for (int i = 0; i < items.Length; i++)
                {
                    tempArray[i] = items[i];
                }

                items = tempArray;
            }

            items[Count++] = element;
        }
        public void Print()
        {
            Console.WriteLine(string.Join(", ", items));
        }
        public int RemoveAt(int index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            int element = items[index];
            items[index] = 0;

            for (int i = index; i < Count; i++)
            {
                items[i] = items[i + 1];
            }
            
            Count--;

            if (Count <= items.Length / 4)
            {
                int[] tempArray = new int[items.Length / 2];
                for(int i = 0;i < Count;i++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;
            }

            return element;
        }
        public bool Contains(int element)
        {
           for (int i = 0; i < items.Length; i++)
           {
                if (items[i] == element) return true;
           }

            return false;
        }
        public void Swap(int firstindex, int lastindex)
        {
            if(firstindex < 0 || firstindex >= Count
                || lastindex < 0 || lastindex >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            int tempElement = items[firstindex];
            items[firstindex] = items[lastindex];
            items[lastindex] = tempElement;
        }
        private void IsInRange(int i)
        {
            if (i < 0 || i >= Count)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
