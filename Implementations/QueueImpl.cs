namespace estrutura_dados.Implementations
{
    public class QueueImpl<T>
    {
        T[] Elements;
        int Size;
        int Capacity;
        int Head;
        int Tail;

        public QueueImpl(int capacity = 10)
        {
            Capacity = capacity;
            Size = 0;
            Elements = new T[capacity];
            Head = 0;
            Tail = -1;
        }

        public void Enqueue(T element)
        {
            if (Size >= Capacity)
            {
                throw new Exception("A fila está cheia");
            }

            Tail = (Tail + 1) % Capacity;
            Elements[Tail] = element;
            Size++;
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("A fila está vazia");
            }

            Head = (Head + 1) % Capacity;
            Size--;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("A fila está vazia");
            }

            return Elements[Head];
        }

        public T[] GetCopy()
        {
            T[] copy = new T[Size];
            for (int i = 0; i < Size; i++)
            {
                copy[i] = Elements[(Head + i) % Capacity];
            }

            return copy;
        }

        public int GetSize => Size;
        public bool IsEmpty() => Size == 0;

        public void Clear()
        {
            Size = 0;
            Head = 0;
            Tail = -1;
        }
    }
}