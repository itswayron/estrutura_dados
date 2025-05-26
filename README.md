# Visualizador de Estruturas de Dados em Console

Este projeto é uma aplicação de console desenvolvida em C# que permite visualizar e manipular diversas estruturas de dados clássicas, como arrays, matrizes, filas, pilhas e listas. O sistema possui um menu interativo colorido, que facilita a navegação e a execução de operações básicas, como adicionar, remover, buscar e limpar elementos. É uma ferramenta didática para quem está aprendendo estruturas de dados e deseja experimentar operações comuns de forma prática e visual.

## Instalação

1. Clone o repositório para sua máquina local: 

```bash
  git clone https://github.com/itswayron/estrutura_dados
```

2. Abra o projeto em sua IDE preferida (Visual Studio, Rider, VS Code com extensão C#).
3. Compile o projeto para garantir que não há erros.
4. Execute o projeto diretamente pela IDE ou no terminal, usando o comando:
```bash
  dotnet run
```
5. Navegue pelo menu utilizando os números das opções e explore as funcionalidades.

## Pré-requisitos de Execução
- .NET SDK instalado (versão 8.0 ou superior recomendada).
- Console/terminal com suporte a sequências ANSI para cores (a maioria dos terminais modernos suporta, como Windows Terminal, PowerShell, Linux terminal e macOS Terminal).
- Ambiente de desenvolvimento C# (Visual Studio, VS Code, Rider, ou apenas linha de comando).

## Exemplos de Uso

Ao iniciar o programa, o menu principal é exibido:
``` markdown
======= MENU INICIAL =======
0. Sair.
1. Visualizar Array.
2. Visualizar Matriz.
3. Visualizar Fila.
4. Visualizar Pilha.
5. Visualizar Lista / Algorítimos de Busca.
```

Digite o número da opção desejada e pressione Enter. Por exemplo, ao digitar 1, você acessa o menu de operações com arrays, podendo adicionar elementos, remover, visualizar ou limpar o array.

Em cada submenu, siga as instruções para realizar operações específicas. Use o 0 para voltar ao menu anterior ou sair do programa.

## Estrutura do Menu e Comandos Disponíveis

### Menu Inicial

0. Sair: Encerra o programa.
1. Visualizar Array: Acessa opções para manipular arrays.
2. Visualizar Matriz: Manipulação de matrizes (operações semelhantes às do array, mas em duas dimensões).
3. Visualizar Fila: Operações típicas de fila (enfileirar, desenfileirar, visualizar).
4. Visualizar Pilha: Operações de pilha (empilhar, desempilhar, visualizar).
5. Visualizar Lista / Algorítmos de Busca: Manipulação de listas e execução de algoritmos de busca sequencial e binária.

#### Submenus (exemplo Array)

- Adicionar elemento
- Remover elemento pelo índice
- Buscar elemento
- Limpar array
- Visualizar conteúdo atual

Cada submenu possui opções numéricas para executar essas ações e apresenta mensagens coloridas para facilitar o entendimento do status da operação.