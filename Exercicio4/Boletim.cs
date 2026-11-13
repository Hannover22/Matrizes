Console.Write("Informe o nome do aluno: ");
string nome = Console.ReadLine();
Console.Write("Informe a quantidade de disciplinas: ");
int tamanho = int.Parse(Console.ReadLine());
string[] disciplinas = new string[tamanho];
Console.WriteLine("Informe o nome das disciplinas: ");
float[] medias = new float[tamanho];
string[] status = new string[tamanho];


for(int i = 0; i < tamanho; i++)
{
    Console.Write($"Disciplina {i + 1}: ");
    disciplinas[i] = Console.ReadLine();
}

float[,] notas = new float[tamanho, 4];
void PopulaNotas(float[,] notas, int disciplina)
{
    for(int i = 0; i < 4; i++)
    {
        Console.Write($"Informe a nota {i + 1} da disciplina {disciplinas[disciplina]}: ");
        notas[disciplina, i] = float.Parse(Console.ReadLine());
    }
}

void CalculaMedia(float[,] notas, int disciplina)
{
    for(int i = 0; i < 4; i++)
    {
        medias[disciplina] += notas[disciplina, i];
    }
    medias[disciplina] /= 4;
}

void CalculaStatus(float[] medias, int disciplina)
{
    if (medias[disciplina] >= 7)
    {
        status[disciplina] = "Aprovado";
    }
    else if (medias[disciplina] >= 5)
    {
        status[disciplina] = "Recuperação";
    }
    else
    {
        status[disciplina] = "Reprovado";
    }
}

void ImprimeBoletim(string nome, string[] disciplinas, float[,] notas, float[] medias, string[] status)
{
    Console.WriteLine($"Boletim do aluno {nome}");
    for(int i = 0; i < tamanho; i++)
    {
        Console.WriteLine("\n");
        Console.Write($"{disciplinas[i]}:");
        for(int j = 0; j < 4; j++)
        {
            Console.Write($"{notas[i, j]}");
        }
        Console.Write($"Média: {medias[i]} - Status: {status[i]}");
    }
}

for (int i = 0; i < tamanho; i++)
{
    PopulaNotas(notas, i);
    CalculaMedia(notas, i);
    CalculaStatus(medias, i);
}

ImprimeBoletim(nome, disciplinas, notas, medias, status);