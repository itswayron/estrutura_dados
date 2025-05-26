using estrutura_dados.Implementations;

namespace estrutura_dados.Visualizations
{
    public static class QueueVisualization
    {
        public static void Visualize()
        {
            Console.Clear();
            AnsiColors.WriteLine("======= VISUALIZAÇÃO DE FILA =======", AnsiColors.Cyan);
            
            int size = MenuCreator.ReadIntInput("Digite o tamanho da fila: ");
            QueueImpl<int> queue = new QueueImpl<int>(size);

            var menuInterface = () =>
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
                ]);
            };

            var menuActions = new List<Action>()
            {
                () =>
                {
                    var element = MenuCreator.ReadIntInput("Digite o número a ser adicionado: ");
                    queue.Enqueue(element);
                },
                () => { queue.Dequeue(); },
                () =>
                {
                    if (queue.IsEmpty())
                    {
                        AnsiColors.WriteLine("A fila está vazia.", AnsiColors.Red);
                    }
                    else
                    {
                        AnsiColors.WriteLine("A fila não está vazia.", AnsiColors.Green);
                    }
                },
                () =>
                {
                    int firstElement = queue.Peek();
                    AnsiColors.WriteLine($"Primeiro elemento: {firstElement}", AnsiColors.Green);
                },
                () => { AnsiColors.WriteLine($"Tamanho da fila: {queue.GetSize}", AnsiColors.Green); },
                () =>
                {
                    queue.Clear();
                    AnsiColors.WriteLine("Fila limpa!", AnsiColors.Green);
                }
            };

            MenuCreator.ExecuteMenu(menuActions, menuInterface);
            Console.Clear();
        }
    }
}