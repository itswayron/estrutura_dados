namespace estrutura_dados.Implementations;

public class ListImpl<T> where T : IComparable<T>
{
    T[] Elements;
    int Size;
    int Capacity;

    public ListImpl(int capacity = 10)
    {
        Capacity = capacity;
        Size = 0;
        Elements = new T[Capacity];
    }

    private void CheckIndex(int index)
    {
        if (index < 0 || index >= Size)
            throw new Exception($"Posição {index} inválida.");
    }

    private void CheckCapacity()
    {
        if (Size >= Capacity)
            throw new Exception("Lista cheia!");
    }

    public void Add(T element)
    {
        CheckCapacity();
        Elements[Size++] = element;
    }

    public void AddAt(T element, int index)
    {
        CheckIndex(index);
        for (int i = Size; i > index; i--)
        {
            Elements[i] = Elements[i - 1];
        }

        Elements[index] = element;
        Size++;
    }

    public void RemoveAt(int index)
    {
        CheckIndex(index);
        Elements[index] = Elements[Size - 1];
        Size--;
    }

    public T[] GetCopy()
    {
        T[] copy = new T[Size];
        Array.Copy(Elements, copy, Size);
        return copy;
    }

    public void Clear()
    {
        Elements = new T[Capacity];
        Size = 0;
    }


    public void Sort()
    {
        Array.Sort(Elements, 0, Size);
    }

    public (int index, int steps) LinearSearch(T element)
    {
        int steps = 0;
        for (int i = 0; i < Size; i++)
        {
            steps++;
            if (element.Equals(Elements[i]))
            {
                return (i, steps);
            }
        }

        return (-1, steps);
    }

    public (int index, int steps) BinarySearch(T element)
    {
        int steps = 0; // If you consider to Sort the whole Array as a step, you could put this as 1
        Sort();
        int left = 0;
        int right = Size - 1;

        while (left <= right)
        {
            steps++;
            int middle = (left + right) / 2;
            int comparison = element.CompareTo(Elements[middle]);

            if (comparison == 0)
            {
                return (middle, steps);
            }

            if (comparison < 0)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return (-1, steps);
    }
}