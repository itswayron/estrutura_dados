using estrutura_dados.Implementations;

namespace estrutura_dados.Visualizations
{
    public static class ArrayVisualization
    {
        public static void Visualize()
        {
            Console.Clear();
            AnsiColors.WriteLine("======= VISUALIZAÇÃO DE ARRAY =======", AnsiColors.Cyan);
            AnsiColors.Write("Digite o tamanho do array: ", AnsiColors.Blue);
            int size = int.Parse(Console.ReadLine());

            var array = new ArrayImpl<int>(size);

            var menuInterface = () =>
            {
                AnsiColors.PrintMenu(
                [
                    "Adicionar elemento.",
                    "Remover elemento.",
                    "Obter elemento por índice.",
                    "Verificar se está vazio.",
                    "Obter tamanho.",
                    "Obter capacidade.",
                    "Limpar array.",
                    "Imprimir array."
                ], "MENU DO ARRAY");
            };

            var menuActions = new List<Action>()
            {
                () =>
                {
                    AnsiColors.Write("Digite o elemento a ser adicionado: ", AnsiColors.Green);
                    int element = int.Parse(Console.ReadLine());
                    array.Add(element);
                    AnsiColors.WriteLine("Elemento adicionado com sucesso!");
                },
                () =>
                {
                    AnsiColors.Write("Digite o índice do elemento a ser removido: ", AnsiColors.Red);
                    int indexToRemove = int.Parse(Console.ReadLine());
                    array.Remove(indexToRemove);
                    AnsiColors.WriteLine("Elemento removido com sucesso!");
                },
                () =>
                {
                    AnsiColors.Write("Digite o índice: ", AnsiColors.Magenta);
                    int index = int.Parse(Console.ReadLine());
                    int value = array.GetAtIndex(index);
                    AnsiColors.WriteLine($"Elemento na posição {index}: {value}");
                },
                () =>
                {
                    bool isEmpty = array.IsEmpty();
                    AnsiColors.WriteLine(isEmpty ? "O array está vazio." : "O array NÃO está vazio.",
                        AnsiColors.White);
                },
                () => { AnsiColors.WriteLine($"Tamanho atual: {array.GetSize}", AnsiColors.Green); },
                () => { AnsiColors.WriteLine($"Capacidade máxima: {array.GetCapacity}", AnsiColors.Green); },
                () =>
                {
                    array.Clear();
                    AnsiColors.WriteLine("Array limpo com sucesso!", AnsiColors.Red);
                },
                () =>
                {
                    AnsiColors.WriteLine("Conteúdo do array:", AnsiColors.Cyan);
                    array.Print();
                }
            };

            MenuVisualization.ExecuteMenu(menuActions, menuInterface);
            Console.Clear();
        }
    }
}