// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


int [,] array = new int[5,3];

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


void SumStrElArray()
{
    for (int i = 0; i < array.GetLength(0);i++)
    {
        int sumStr = 0;
        for (int j = 0; j < array.GetLength(1);j++)
        {
            sumStr = sumStr + array[i,j];
        }
        System.Console.WriteLine("Сумма = "+ sumStr);
    }
    System.Console.WriteLine();
}


CreateArray();
PrintArray();
SumStrElArray();