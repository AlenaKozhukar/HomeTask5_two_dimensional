// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


int [,] array = new int[3,3];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] +" ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void ChangeArray()
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i > 0 && i < array.GetLength(1))
            {
                temp = array[i, j];
                array[i, j] = array[i, j];
                array[i, j] = temp;
            }
            else
            {
                temp = array[i, j];
                array[i, j] = array[(array.GetLength(1) - 1), j];
                array[(array.GetLength(1) - 1), j] = temp;
            }
        }
        System.Console.WriteLine();
    }
}

CreateArray();
PrintArray();
ChangeArray();
PrintArray();