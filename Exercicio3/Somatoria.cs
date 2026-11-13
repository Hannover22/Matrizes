using System.Security.Cryptography;

Console.Write("Digite a quantidade de linhas: ");
int linhas = int.Parse(Console.ReadLine());
Console.Write("Digite a quantidade de colunas: ");
int colunas = int.Parse(Console.ReadLine());

int[,] m1 = new int[linhas, colunas];
int[] resultados = new int[linhas];
int[] resultadosColunas = new int[colunas];
int[] resultadosDiagonais = new int[2];

void PopulaMatriz(int linhas, int colunas)
{
    for(int i = 0; i < linhas; i++)
    {
        for(int j = 0; j < colunas; j++)
        {
            m1[i, j] = RandomNumberGenerator.GetInt32(1, 9);
        }
    }
}

int SomaLinha(int linha)
{
    int resultado = 0;
    for (int i = 0; i < linhas; i++)
    {
        resultado += m1[linha, i];
    }
    return resultado;
}

int SomaColuna(int coluna)
{
    int resultado = 0;
    for(int i = 0; i < colunas; i++)
    {
        resultado += m1[i, coluna];
    }
    return resultado;
}

int[] SomaDiagonal(int linha, int coluna)
{
    int[] resultado = new int[2];
    for(int i = 0; i < linhas; i++)
    {
        for(int j = 0; j < colunas; j++)
        {
            if(i == j)
            {
                resultado[0] += m1[i, j];
            }
            if (colunas-1 == i + j)
            {
                resultado[1] += m1[i, j];
            }
        }
    }
    return resultado;
}

void ImprimeResultados(int[] resultados, int linhas, int colunas)
{
    for(int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            Console.Write($"[{m1[i, j]}]");
        }
        Console.WriteLine($" = {resultados[i]}");
    }
}

void ImprimeResultadosColunas(int[] resultados, int linhas, int colunas)
{
    for(int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            Console.Write($"[{m1[i, j]}]");

        }
        Console.WriteLine("\n");
    }
    for(int i = 0; i < colunas; i++)
    {
        Console.Write(" ||");
    }
    Console.WriteLine("\n");
    for(int i = 0; i < colunas; i++)
    {
        Console.Write($"[{resultados[i]}]");
    }
}


void ImprimeResultadoDiagonal(int[] resultados, int linhas, int colunas)
{
    for(int i = 0; i < linhas; i++)
    {
        for(int j = 0; j < colunas; j++)
        {
            Console.Write($"[{m1[i, j]}]");
        }
        Console.WriteLine("\n");
    }
    for(int i = 0; i < resultados.Length; i++)
    {
        Console.Write($"[{resultados[i]}]");
    }
}

PopulaMatriz(linhas, colunas);
for(int i = 0; i < linhas; i++)
{
    resultados[i] = SomaLinha(i);
}
for(int i = 0; i < colunas; i++)
{
    resultadosColunas[i] = SomaColuna(i);
}

resultadosDiagonais = SomaDiagonal(linhas, colunas);
ImprimeResultados(resultados, linhas, colunas);
Console.WriteLine("\n\n");
ImprimeResultadosColunas(resultadosColunas, linhas, colunas);
Console.WriteLine("\n\n");
ImprimeResultadoDiagonal(resultadosDiagonais, linhas, colunas);