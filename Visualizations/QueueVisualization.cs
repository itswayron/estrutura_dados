using estrutura_dados.Implementations;

namespace estrutura_dados.Visualizations
{
    public static class QueueVisualization
    {
        public static void Visualize()
        {
            Console.Clear();
            AnsiColors.WriteLine("======= VISUALIZAÇÃO DE FILA =======", AnsiColors.Cyan);
            AnsiColors.Write("Digite o tamanho da fila: ", AnsiColors.Blue);
            if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                AnsiColors.WriteLine("Tamanho inválido. Encerrando...", AnsiColors.Red);
                return;
            }

            QueueImpl<int> queue = new QueueImpl<int>(size);

            int option;
            do
            {
                AnsiColors.WriteLine("======= FILA =======", AnsiColors.Cyan);
                Console.WriteLine($"{AnsiColors.Green}Fila: {string.Join(" -> ", queue.GetCopy())}{AnsiColors.Reset}");
                AnsiColors.PrintMenu([
                    "Enfileirar.",
                    "Desenfileirar.",
                    "Verificar se está vazia.",
                    "Ver primeiro elemento.",
                    "Ver tamanho.",
                    "Limpar fila.",
                    "Imprimir fila.",
                ]);

                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    AnsiColors.WriteLine("Opção inválida!", AnsiColors.Red);
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();
                try
                {
                    switch (option)
                    {
                        case 0:
                            AnsiColors.WriteLine("Saindo...", AnsiColors.Red);
                            break;
                        case 1:
                            Console.Write("Digite o número a ser adicionado: ");
                            var element = int.Parse(Console.ReadLine());
                            queue.Enqueue(element);
                            break;
                        case 2:
                            queue.Dequeue();
                            break;
                        case 3:
                            if (queue.IsEmpty())
                            {
                                AnsiColors.WriteLine("A fila está vazia.", AnsiColors.Red);
                            }
                            else
                            {
                                AnsiColors.WriteLine("A fila não está vazia.", AnsiColors.Green);
                            }

                            break;
                        case 4:
                            int firstElement = queue.Peek();
                            AnsiColors.WriteLine($"Primeiro elemento: {firstElement}", AnsiColors.Green);
                            break;
                        case 5:
                            AnsiColors.WriteLine($"Tamanho da fila: {queue.GetSize}", AnsiColors.Green);
                            break;
                        case 6:
                            queue.Clear();
                            AnsiColors.WriteLine("Fila limpa!", AnsiColors.Green);
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