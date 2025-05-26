using estrutura_dados.Implementations;

namespace estrutura_dados.Visualizations
{
    public static class MatrixVisualization
    {
        public static void Visualize()
        {
            Console.Clear();
            AnsiColors.WriteLine("======= VISUALIZAÇÃO DE MATRIZ =======", AnsiColors.Cyan);

            int rows = MenuCreator.ReadIntInput("Digite o número de linhas: ");
            int cols = MenuCreator.ReadIntInput("Digite o número de colunas: ");

            var matrix = new MatrixImpl<int>(rows, cols);

            var menuInterface = () =>
            {
                AnsiColors.WriteLine("======= MATRIZ =======", AnsiColors.Cyan);
                matrix.Print();
                AnsiColors.PrintMenu([
                    "Inserir elemento.",
                    "Inserir elemento na posição.",
                    "Obter elemento.",
                    "Limpar matriz.",
                    "Obter número de linhas/colunas.",
                    "Imprimir matriz."
                ]);
            };

            var menuActions = new List<Action>()
            {
                () =>
                {
                    int newVal = MenuCreator.ReadIntInput("Valor: ");
                    matrix.AddFirstFree(newVal);
                    AnsiColors.WriteLine("Elemento adicionado na primeira posição livre!");
                },
                () =>
                {
                    int row = MenuCreator.ReadIntInput("Linha: ");
                    int col = MenuCreator.ReadIntInput("Coluna: ");
                    int value = MenuCreator.ReadIntInput("Valor: ");
                    matrix.SetAtIndex(row, col, value);
                    AnsiColors.WriteLine("Elemento inserido com sucesso!");
                },
                () =>
                {
                    int r = MenuCreator.ReadIntInput("Linha: ");
                    int c = MenuCreator.ReadIntInput("Coluna: ");
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

            MenuCreator.ExecuteMenu(menuActions, menuInterface);
            Console.Clear();
        }
    }
}