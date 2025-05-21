using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estrutura_dados.Array;

namespace estrutura_dados.Visualizations
{
    public class ArrayVisualization
    {
        public void Visualize()
        {
            Console.Clear();
            AnsiColors.WriteLine("======= VISUALIZAÇÃO DE ARRAY =======", AnsiColors.Cyan);
            AnsiColors.Write("Digite o tamanho do array: ", AnsiColors.Blue);

            if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                AnsiColors.WriteLine("Tamanho inválido. Encerrando...", AnsiColors.Red);
                return;
            }

            var array = new ArrayImpl<int>(size);
            int option;

            do
            {
                AnsiColors.WriteLine("======= MENU DO ARRAY =======", AnsiColors.Cyan);
                Console.WriteLine($"{AnsiColors.Red}0. Sair.{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}1.{AnsiColors.Reset + AnsiColors.Green} Adicionar elemento.{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}2.{AnsiColors.Reset + AnsiColors.Green} Remover elemento{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}3.{AnsiColors.Reset + AnsiColors.Green} Obter elemento por índice.{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}4.{AnsiColors.Reset + AnsiColors.Green} Verificar se está vazio.{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}5.{AnsiColors.Reset + AnsiColors.Green} Obter tamanho.{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}6.{AnsiColors.Reset + AnsiColors.Green} Obter capacidade.{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}7.{AnsiColors.Reset + AnsiColors.Green} Limpar array.{AnsiColors.Reset}");
                Console.WriteLine($"{AnsiColors.Yellow}8.{AnsiColors.Reset + AnsiColors.Green} Imprimir array.{AnsiColors.Reset}");
                Console.Write("Opção: ", AnsiColors.Yellow);

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
                            AnsiColors.Write("Digite o elemento a ser adicionado: ", AnsiColors.Green);
                            int element = int.Parse(Console.ReadLine());
                            array.Add(element);
                            AnsiColors.WriteLine("Elemento adicionado com sucesso!");
                            break;

                        case 2:
                            AnsiColors.Write("Digite o índice do elemento a ser removido: ", AnsiColors.Red);
                            int indexToRemove = int.Parse(Console.ReadLine());
                            array.Remove(indexToRemove);
                            AnsiColors.WriteLine("Elemento removido com sucesso!");
                            break;

                        case 3:
                            AnsiColors.Write("Digite o índice: ", AnsiColors.Magenta);
                            int index = int.Parse(Console.ReadLine());
                            int value = array.GetAtIndex(index);
                            AnsiColors.WriteLine($"Elemento na posição {index}: {value}");
                            break;

                        case 4:
                            bool isEmpty = array.IsEmpty();
                            AnsiColors.WriteLine(isEmpty ? "O array está vazio." : "O array NÃO está vazio.", AnsiColors.White);
                            break;

                        case 5:
                            AnsiColors.WriteLine($"Tamanho atual: {array.GetSize}", AnsiColors.Green);
                            break;

                        case 6:
                            AnsiColors.WriteLine($"Capacidade máxima: {array.GetCapacity}", AnsiColors.Green);
                            break;

                        case 7:
                            array.Clear();
                            AnsiColors.WriteLine("Array limpo com sucesso!", AnsiColors.Red);
                            break;

                        case 8:
                            AnsiColors.WriteLine("Conteúdo do array:", AnsiColors.Cyan);
                            array.Print();
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

