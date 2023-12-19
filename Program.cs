// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


int [,] array = new int[5,3];
int [] array2 = new int [array.GetLength(0)];

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

void SumElStrArray()
{
    for (int i = 0; i < array.GetLength(0);i++)
    {
        int sumStr = 0;
        for (int j = 0; j < array.GetLength(1);j++)
        {
            sumStr += array[i,j];
        }
        array2[i] = sumStr;
    }
}

void PrintArray2()
{
    for (int i =0; i<array2.Length; i++)
    {
        System.Console.Write(array2[i] + " ");
    }
}

Console.WriteLine();

void PrintStrMinSum()
{
    int minSum = array2[0];
    for (int i = 0; i < array2.Length; i++)
    {  
        if (array2[i] < minSum)
        {
            minSum = array2[i];
            int indexMin = Convert.ToInt32(i);
            Console.WriteLine("индекс строки, где минимальная сумма элементов: " + indexMin);
        }
    }
    Console.WriteLine();
}



CreateArray();
PrintArray();
SumElStrArray();
PrintArray2();
System.Console.WriteLine();
PrintStrMinSum();