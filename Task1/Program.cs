/*
Задайте двумерный массив символов (тип char
[,]). Создать строку из символов этого массива. 
*/


void Main()
{
    int rows = 3;
    int columns = 3;

    char[,] charMatrix = GenerateCharMatrix(rows, columns);
    PrintMatrix(charMatrix);
    System.Console.WriteLine(GetStringFromMatrix(charMatrix));
}

void PrintMatrix(char[,] charMatrix)
{
    for (int i = 0; i < charMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < charMatrix.GetLength(1); j++)
        {
            System.Console.Write(charMatrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

string GetStringFromMatrix(char[,] charMatrix)
{
    int columns = charMatrix.GetLength(1);
    char[] array = new char[charMatrix.GetLength(0) * charMatrix.GetLength(1)];
    for (int i = 0; i < charMatrix.GetLength(0); i++)
    {   
        for (int j = 0; j < charMatrix.GetLength(1); j++)
        {
            int arrayIndex = columns * i + j;
            array[arrayIndex] = charMatrix[i, j];
        }
        
    }

    return string.Join("", array);
}

char[,] GenerateCharMatrix(int rows, int columns)
{
    string alpchaChars = "qwertyuiopasdfghjklzxcvbnm";
    int lenAlpha = alpchaChars.Length;
    var rnd = new Random();
    var matrix = new char[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int index = rnd.Next(0, lenAlpha);
            matrix[i, j] = alpchaChars[index];
        }
    }

    return matrix;

}

Main();