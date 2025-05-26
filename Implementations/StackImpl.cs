namespace estrutura_dados.Implementations;

public class StackImpl<T>
{
    T[] Elements;
    int Capacity;
    int Top;

    public StackImpl(int size = 10)
    {
        Capacity = size;
        Elements = new T[Capacity];
        Top = -1;
    }

    public bool IsEmpty() => Top == -1;

    public bool IsFull() => Top == Capacity - 1;
    

    public int Size() => Top + 1;

    public void Push(T element)
    {
        if (IsFull()) throw new Exception("Stack Full");

        Elements[++Top] = element;
    }

    public T Pop()
    {
        if (IsEmpty()) throw new Exception("Stack Empty");
        return Elements[Top--];
    }

    public void Clear()
    {
        Elements = new T[Capacity];
        Top = -1;
    }

    public T[] GetCopy()
    {
        T[] copy = new T[Size()];
        for (int i = 0; i <= Top; i++)
        {
            copy[i] = Elements[i];
        }
        return copy;
    }
}