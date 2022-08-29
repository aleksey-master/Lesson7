/*Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

void FillMatrix(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(-9, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write("{0,6}", matrix[i, j]);
        }
        System.Console.WriteLine();
    }
}

int m = Prompt("Введите высоту массива: m= ");
int n = Prompt("Введите длину массива: n= ");
int[,] matrix = new int[m, n];

FillMatrix(matrix);
System.Console.WriteLine("");
PrintMatrix(matrix);

int[,] arrayWhole = new int[m, n];
arrayWhole = TransformationArrayWhole(matrix);

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < m; j++)
    {
        arithmeticMean += arrayWhole[j, i];
    }
    arithmeticMean = Math.Round(arithmeticMean / m, 1);
    Console.WriteLine($"столбца № {i + 1} = {arithmeticMean}");
}

int[,] TransformationArrayWhole(int[,] matrix)
{
    int[,] arrayWhole = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arrayWhole[i, j] = Convert.ToInt32(matrix[i, j]);
        }
    }
    return arrayWhole;
}

void WriteArrayInt(int[,] arrayWhole)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arrayWhole[i, j] + " ");
        }
        Console.WriteLine();
    }
}
