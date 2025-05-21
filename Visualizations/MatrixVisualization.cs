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

            if (!int.TryParse(Console.ReadLine(), out int rows) || rows <= 0)
            {
                AnsiColors.WriteLine("Número de linhas inválido. Encerrando...", AnsiColors.Red);
                return;
            }

            AnsiColors.Write("Digite o número de colunas: ", AnsiColors.Blue);

            if (!int.TryParse(Console.ReadLine(), out int cols) || cols <= 0)
            {
                AnsiColors.WriteLine("Número de colunas inválido. Encerrando...", AnsiColors.Red);
                return;
            }

            var matrix = new MatrixImpl<int>(rows, cols);
            int option;

            do
            {
                AnsiColors.PrintMenu([
                    "Inserir elemento.",
                    "Inserir elemento na posição.",
                    "Obter elemento.",
                    "Limpar matriz.",
                    "Obter número de linhas/colunas.",
                    "Imprimir matriz."
                ], "MENU DA MATRIZ");

                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    AnsiColors.WriteLine("Opção inválida!", AnsiColors.Red);
                    Console.ReadKey();
                    continue;
                }

                try
                {
                    Console.Clear();
                    Console.WriteLine();

                    switch (option)
                    {
                        case 1:
                            AnsiColors.Write("Valor: ", AnsiColors.Green);
                            int newVal = int.Parse(Console.ReadLine());
                            matrix.AddFirstFree(newVal);
                            AnsiColors.WriteLine("Elemento adicionado na primeira posição livre!");
                            break;

                        case 2:
                            AnsiColors.Write("Linha: ", AnsiColors.Green);
                            int row = int.Parse(Console.ReadLine());
                            AnsiColors.Write("Coluna: ", AnsiColors.Green);
                            int col = int.Parse(Console.ReadLine());
                            AnsiColors.Write("Valor: ", AnsiColors.Green);
                            int value = int.Parse(Console.ReadLine());
                            matrix.SetAtIndex(row, col, value);
                            AnsiColors.WriteLine("Elemento inserido com sucesso!");
                            break;

                        case 3:
                            AnsiColors.Write("Linha: ", AnsiColors.Magenta);
                            int r = int.Parse(Console.ReadLine());
                            AnsiColors.Write("Coluna: ", AnsiColors.Magenta);
                            int c = int.Parse(Console.ReadLine());
                            int element = matrix.GetAtIndex(r, c);
                            AnsiColors.WriteLine($"Valor em [{r},{c}] = {element}");
                            break;

                        case 4:
                            matrix.Clear();
                            AnsiColors.WriteLine("Matriz limpa com sucesso!", AnsiColors.Red);
                            break;

                        case 5:
                            AnsiColors.WriteLine($"Linhas: {matrix.GetRows} | Colunas: {matrix.GetColumns}",
                                AnsiColors.Green);
                            break;

                        case 6:
                            AnsiColors.WriteLine("Conteúdo da matriz:", AnsiColors.Cyan);
                            matrix.Print();
                            break;

                        case 0:
                            AnsiColors.WriteLine("Saindo...", AnsiColors.Red);
                            break;

                        default:
                            AnsiColors.WriteLine("Opção inválida!", AnsiColors.Red);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    AnsiColors.WriteLine($"Erro: {ex.Message}", AnsiColors.Red);
                }
            } while (option != 0);
        }
    }
}