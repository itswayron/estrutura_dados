using estrutura_dados.Implementations;

namespace estrutura_dados.Visualizations
{
    public static class MatrixVisualization
    {
        public static void Visualize()
        {
            Console.Clear();
            AnsiColors.WriteLine("======= VISUALIZAÇÃO DE MATRIZ =======", AnsiColors.Cyan);
            
            AnsiColors.Write("Digite o número de linhas: ", AnsiColors.Blue);
            int rows = int.Parse(Console.ReadLine());
            AnsiColors.Write("Digite o número de colunas: ", AnsiColors.Blue);
            int cols = int.Parse(Console.ReadLine());

            var matrix = new MatrixImpl<int>(rows, cols);

            var menuInterface = () =>
            {
                AnsiColors.PrintMenu([
                    "Inserir elemento.",
                    "Inserir elemento na posição.",
                    "Obter elemento.",
                    "Limpar matriz.",
                    "Obter número de linhas/colunas.",
                    "Imprimir matriz."
                ], "MENU DA MATRIZ");
            };

            var menuActions = new List<Action>()
            {
                () =>
                {
                    AnsiColors.Write("Valor: ", AnsiColors.Green);
                    int newVal = int.Parse(Console.ReadLine());
                    matrix.AddFirstFree(newVal);
                    AnsiColors.WriteLine("Elemento adicionado na primeira posição livre!");
                },
                () =>
                {
                    AnsiColors.Write("Linha: ", AnsiColors.Green);
                    int row = int.Parse(Console.ReadLine());
                    AnsiColors.Write("Coluna: ", AnsiColors.Green);
                    int col = int.Parse(Console.ReadLine());
                    AnsiColors.Write("Valor: ", AnsiColors.Green);
                    int value = int.Parse(Console.ReadLine());
                    matrix.SetAtIndex(row, col, value);
                    AnsiColors.WriteLine("Elemento inserido com sucesso!");
                },
                () =>
                {
                    AnsiColors.Write("Linha: ", AnsiColors.Magenta);
                    int r = int.Parse(Console.ReadLine());
                    AnsiColors.Write("Coluna: ", AnsiColors.Magenta);
                    int c = int.Parse(Console.ReadLine());
                    int element = matrix.GetAtIndex(r, c);
                    AnsiColors.WriteLine($"Valor em [{r},{c}] = {element}");
                },
                () =>
                {
                    matrix.Clear();
                    AnsiColors.WriteLine("Matriz limpa com sucesso!", AnsiColors.Red);
                },
                () =>
                {
                    AnsiColors.WriteLine($"Linhas: {matrix.GetRows} | Colunas: {matrix.GetColumns}",
                        AnsiColors.Green);
                },
                () =>
                {
                    AnsiColors.WriteLine("Conteúdo da matriz:", AnsiColors.Cyan);
                    matrix.Print();
                }
            };

            MenuVisualization.ExecuteMenu(menuActions, menuInterface);
            Console.Clear();
        }
    }
}