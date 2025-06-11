using estrutura_dados.Implementations;

namespace estrutura_dados.Visualizations;

public static class HashTableVisualization
{
    public static void Visualize()
    {
        Console.Clear();

        AnsiColors.WriteLine("======= VISUALIZAÇÃO DE HASH TABLE =======", AnsiColors.Cyan);
        int size = MenuCreator.ReadIntInput("Digite a capacidade da Hash Table: ");

        var hashTable = new HashTableImpl<int>(size);
        var menuInterface = () =>
        {
            AnsiColors.PrintMenu([
                "Adicionar elemento.",
                "Buscar elemento.",
                "Remover elemento.",
                "Exibir tabela"
                ], "Hash Table.");
        };

        var menuActions = new List<Action>()
        {
            () =>
            {
                int value = MenuCreator.ReadIntInput("Digite o valor a ser inserido: ");
                hashTable.Insert(value);
                AnsiColors.WriteLine($"Valor {value} inserido à Hash Table com sucesso.", AnsiColors.Cyan);
            },
            () =>
            {
                int value = MenuCreator.ReadIntInput("Digite o valor que você gostaria de buscar: ");
                bool isPresent = hashTable.Search(value);
                if(isPresent) {
                    AnsiColors.WriteLine($"O valor {value} está presente na lista!", AnsiColors.Green);
                } else {
                    AnsiColors.WriteLine($"O valor {value} não está presente na lista.", AnsiColors.Red);
                }
            },
            () =>
            {
                int value = MenuCreator.ReadIntInput("Digite o valor que você gostaria de buscar: ");
                hashTable.Remove(value);
                AnsiColors.WriteLine($"Valor {value} removido da Hash Table!", AnsiColors.Green);
            },
            () =>
            {
                int index = 0;
                foreach(LinkedList<int> list in hashTable.Table) {
                    AnsiColors.WriteLine($"Lista [{index++}] : {string.Join(" -> ", list)}");
                }
            }
        };

        MenuCreator.ExecuteMenu(menuActions, menuInterface);
        Console.Clear();
    }
}