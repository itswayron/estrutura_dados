using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrutura_dados.Implementations
{
    public class ArrayImpl<T>
    {
        T[] Elements;
        int Size;
        int Capacity;
        public ArrayImpl(int capacity = 10)
        {
            Capacity = capacity;
            Size = 0;
            Elements = new T[capacity];
        }
        private void CheckIndex(int index)
        {
            if (index < 0 || index >= Size)
            {
                throw new Exception($"Posição {index} inválida.");
            }
        }

        public void Add(T element)
        {
            if (Size >= Capacity)
            {
                throw new Exception("O Array está cheio");
            }
            Elements[Size++] = element;
        }
        public void Remove(int index)
        {
            CheckIndex(index);
            for (int i = index; i < Size - 1; i++)
            {
                Elements[i] = Elements[i + 1];
            }
            Size--;
        }

        public T[] GetCopy()
        {
            T[] copy = new T[Size];
            Array.Copy(Elements, copy, Size);
            return copy;
        }

        public T GetAtIndex(int index)
        {
            CheckIndex(index);
            return Elements[index];
        }
        public int GetSize => Size;
        public int GetCapacity => Capacity;
        public bool IsEmpty() => Size == 0;
        public void Clear()
        {
            Size = 0;
        }
        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.Write($"[{i}]" + Elements[i] + " -> ");
            }
            Console.WriteLine("null");
        }

    }
}
