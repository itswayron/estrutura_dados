﻿namespace estrutura_dados;

public static class MenuCreator
{
    public static void ExecuteMenu(List<Action> actions, Action menu)
    {
        do
        {
            menu.Invoke();
            try
            {
                int option = ReadIntInput("Opção: ");
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

    public static int ReadIntInput(string prompt = null)
    {
        while (true)
        {
            AnsiColors.Write(prompt, AnsiColors.Green);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                return result;
            }
            Console.Clear();
            AnsiColors.WriteLine("Entrada inválida. Por favor, digite um número inteiro.", AnsiColors.Red);
        }
    }
}