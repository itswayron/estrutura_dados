namespace estrutura_dados.Implementations;

public class HashTableImpl<T>
{
    public List<LinkedList<T>> Table { get; private set;} = new();
    private int Capacity;

    public HashTableImpl(int capacity = 10)
    {
        Capacity = capacity;
        for (int i = 0; i < Capacity; i++)
        {
            Table.Add(new LinkedList<T>());
        }
    }

    private int Hash(T value)
    {
        return Math.Abs(value.GetHashCode()) % Capacity;
    }

    public void Insert(T value)
    {
        int index = Hash(value);
        if (!Table[index].Contains(value))
        {
            Table[index].AddLast(value);
        }
    }

    public bool Search(T value)
    {
        int index = Hash(value);
        return Table[index].Contains(value);
    }

    public void Remove(T value)
    {
        if (Search(value) == false)
        {
            throw new Exception("O item não existe na Hash Table.");
        }
        int index = Hash(value);
        Table[index].Remove(value);
    }
}