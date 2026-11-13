using System.Globalization;
using System.Security.Cryptography;

Console.Write("Digite a quantidade de linhas da matriz: ");
int linhas = int.Parse(Console.ReadLine());
Console.Write("Digite a quantidade de colunas da matriz: ");
int colunas = int.Parse(Console.ReadLine());


int[,] m1 = new int[linhas, colunas];

void GeraMatriz() {
for(int i = 0; i < linhas; i++)
    {
        for(int j = 0; j < colunas; j++)
        {
            m1[i, j] = RandomNumberGenerator.GetInt32(1, 9);
        }
    }
}

void ImprimeMatriz()
{
    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            Console.Write($" [{m1[i, j]}]");
        }
        Console.WriteLine("\n");
    }
}

void ImprimeMatrizInvertida() { 
    for (int i = linhas-1; i >= 0; i--)
    {
        for (int j = colunas-1; j >= 0; j--)
        {
            Console.Write($" [{m1[i, j]}]");
        }
        Console.WriteLine("\n");
    }
}

GeraMatriz();
Console.WriteLine("Matriz gerada: ");
ImprimeMatriz();
Console.WriteLine("\nMatriz invertida: ");
ImprimeMatrizInvertida();