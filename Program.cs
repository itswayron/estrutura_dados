using estrutura_dados;
using estrutura_dados.Visualizations;


var initialMenuInterface = () =>
{
    Console.Clear();
    AnsiColors.PrintMenu([
        "Visualizar Array.",
        "Visualizar Matriz.",
        "Visualizar Lista.",
    ], "MENU INICIAL");
};

var initialMenuActions = new List<Action>()
{
    () =>
    {
        ArrayVisualization.Visualize();
    },
    () =>
    {
        MatrixVisualization.Visualize();
    },
    () =>
    {
        QueueVisualization.Visualize();
    }
};

MenuVisualization.ExecuteMenu(initialMenuActions, initialMenuInterface);
