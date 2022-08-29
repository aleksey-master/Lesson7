/* Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

void FillMatrix(double[,] matrix)
{
    double row = matrix.GetLength(0);
    double column = matrix.GetLength(1);
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(-9, 10);
        }
    }
}

void PrintMatrix(double[,] matrix)
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

void FindElement (double[,] matrix, int element)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
if (element == matrix[i,j])
{
    System.Console.WriteLine($"Искомый элемент: {element} позиция [{i},{j}]");
    return;
}
        }    
    }    
System.Console.WriteLine("Такого числа в массиве нет");
return;
}

int m = Prompt("Введите высоту массива: m= ");
int n = Prompt("Введите длину массива: n= ");
double[,] matrix = new double[m, n];

FillMatrix(matrix);
System.Console.WriteLine("");
PrintMatrix(matrix);
int element = Prompt("Введите искомый элемент: ");
FindElement (matrix, element);
