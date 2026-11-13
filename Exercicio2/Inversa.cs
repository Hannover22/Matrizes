using System.Security.Cryptography;

int[,] m1 = new int[3, 5];
int[,] m2 = new int[5, 3];
int[,] m3 = new int[3, 5];

void GeraMatriz()
{
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 5; j++)
        {
            m1[i, j] = RandomNumberGenerator.GetInt32(1, 9);
        }
    }
}

void PassaMatriz()
{ 
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 5; j++)
        {
            m2[j, i] = m1[i, j];
        }
    }
}

void PassaMatrizInversa()
{
    for(int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            m3[i, j] = m1[2 - i, 4 - j];
        }
    }
}

void ImprimeMatrizes()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write($"[{m1[i, j]}]");
        }
        Console.WriteLine("\n");
    }
    Console.WriteLine("\n");
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write($"[{m2[i, j]}]");
        }
        Console.WriteLine("\n");
    }
    Console.WriteLine("\n");
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 5; j++)
        {
            Console.Write($"[{m3[i, j]}]");
        }
        Console.WriteLine("\n");
    }
}

GeraMatriz();
PassaMatriz();
PassaMatrizInversa();
ImprimeMatrizes();
