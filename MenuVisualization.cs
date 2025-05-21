namespace estrutura_dados;

public static class MenuVisualization
{
    public static void ExecuteMenu(List<Action> actions, Action menu)
    {
        do
        {
            menu.Invoke();
            try
            {
                int option = int.Parse(Console.ReadLine());
                if (option == 0)
                {
                    Console.Clear();
                    AnsiColors.WriteLine("Saindo...", AnsiColors.Red);
                    break;
                }

                if (option < 0 || option > actions.Count)
                {
                    Console.Clear();
                    AnsiColors.WriteLine("Opção inválida!", AnsiColors.Red);
                    continue;
                }

                Console.Clear();
                actions[option - 1].Invoke();
            }
            catch (Exception ex)
            {
                AnsiColors.WriteLine($"Erro: {ex.Message}", AnsiColors.Red);
            }
        } while (true);
    }
}