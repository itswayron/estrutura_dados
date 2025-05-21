using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.Capacity = capacity;
            this.Size = 0;
            this.Elements = new T[capacity];
            this.Head = 0;
            this.Tail = -1;
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
        public int GetCapacity => Capacity;
        public bool IsEmpty() => Size == 0;
        public bool IsFull() => Size == Capacity;
        public int GetHead => Head;
        public int GetTail => Tail;

        public void Clear()
        {
            Size = 0;
            Head = 0;
            Tail = -1;
        }
        public T GetAtIndex(int index)
        {
            if (index < 0 || index >= Size)
            {
                throw new Exception($"Posição {index} inválida.");
            }
            return Elements[(Head + index) % Capacity];
        }
        public void Print()
        {
            Console.WriteLine("Fila:");
            for (int i = 0; i < Size; i++)
            {
                Console.Write(Elements[(Head + i) % Capacity] + " -> ");
            }
            Console.WriteLine("null");
        }
    }
}
