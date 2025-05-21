using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrutura_dados.Array
{
    public class MatrixImpl<T>
    {

        private T[,] Elements;
        private int Rows;
        private int Columns;
        public MatrixImpl(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            this.Elements = new T[rows, columns];
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
            Console.WriteLine("Matriz:");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write($"[{i},{j}] {Elements[i, j]}");
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
