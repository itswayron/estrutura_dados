namespace estrutura_dados.Implementations
{
    public class MatrixImpl<T>
    {
        T[,] Elements;
        int Rows;
        int Columns;

        public MatrixImpl(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Elements = new T[rows, columns];
        }

        private void CheckBounds(int row, int column)
        {
            if (row < 0 || row >= Rows || column < 0 || column >= Columns)
                throw new Exception($"Posição inválida: [{row},{column}]");
        }

        public void AddFirstFree(T element)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (EqualityComparer<T>.Default.Equals(Elements[i, j], default(T)))
                    {
                        Elements[i, j] = element;
                        return;
                    }
                }
            }

            throw new Exception("Matriz cheia. Nenhuma posição livre encontrada.");
        }

        public void SetAtIndex(int row, int column, T value)
        {
            CheckBounds(row, column);
            Elements[row, column] = value;
        }

        public T GetAtIndex(int row, int column)
        {
            CheckBounds(row, column);
            return Elements[row, column];
        }

        public int GetRows => Rows;
        public int GetColumns => Columns;

        public void Clear()
        {
            Elements = new T[Rows, Columns];
        }

        public void Print()
        {
            AnsiColors.WriteLine("Matriz:", AnsiColors.Cyan);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    string index = $"[{i},{j}]";
                    string value = Elements[i, j]?.ToString() ?? "null";
                    AnsiColors.Write(index, AnsiColors.Yellow);
                    Console.Write(" ");
                    AnsiColors.Write(value, AnsiColors.Green);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }
        }
    }
}