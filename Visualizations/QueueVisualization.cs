using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estrutura_dados.Array;

namespace estrutura_dados.Visualizations
{
    public class QueueVisualization
    {
        public void Visualize()
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
                Console.WriteLine($"{AnsiColors.Red}0. Sair{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}1.{AnsiColors.Reset + AnsiColors.Green} Enfileirar.{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}2.{AnsiColors.Reset + AnsiColors.Green} Desenfileirar.{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}3.{AnsiColors.Reset + AnsiColors.Green} Verificar se está vazia.{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}4.{AnsiColors.Reset + AnsiColors.Green} Ver primeiro elemento.{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}5.{AnsiColors.Reset + AnsiColors.Green} Ver tamanho.{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}6.{AnsiColors.Reset + AnsiColors.Green} Limpar fila.{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}7.{AnsiColors.Reset + AnsiColors.Green} Imprimir fila.{AnsiColors.Reset}");
                Console.Write("Opção: ", AnsiColors.Yellow);
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    AnsiColors.WriteLine("Opção inválida!", AnsiColors.Red);
                    Console.ReadKey();
                    continue;
                }
                Console.Clear();
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
            } while (option != 0);
        }
    }
}