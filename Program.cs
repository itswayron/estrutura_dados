using estrutura_dados;
using estrutura_dados.Visualizations;

void InitialMenuInterface()
{
    Console.Clear();
    AnsiColors.PrintMenu([
        "Visualizar Array.",
        "Visualizar Matriz.",
        "Visualizar Fila",
        "Visualizar Pilha",
        "Visualizar Lista / Algorítimos de Busca."
    ], "MENU INICIAL");
};

var initialMenuActions = new List<Action>()
{
    ArrayVisualization.Visualize,
    MatrixVisualization.Visualize,
    QueueVisualization.Visualize,
    StackVisualization.Visualize,
    ListVisualization.Visualize,
};

MenuCreator.ExecuteMenu(initialMenuActions, InitialMenuInterface);