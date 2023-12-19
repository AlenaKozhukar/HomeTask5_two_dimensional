//Задача 1: Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

//7 8 9
//5 1 3  [1,2] => 3 
//0 6 4


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

int ReadNumber()
{
    Console.WriteLine("Введите значение индекса элемента");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool FindElement()
{
    bool isFind = false;
    int num1 = ReadNumber();
    int num2 = ReadNumber();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i==num1 && j==num2)
            {
                Console.WriteLine("по заданному индексу находится число " + array[num1,num2]);
                isFind = true;
            }
        }
    }
    return isFind;
}

void NegativeResult(bool isFind)
{
    bool result = isFind;
    if (result == true)
    {
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("По заданному индексу элемент отсутствует");
    }
}

CreateArray();
PrintArray();
FindElement();
NegativeResult(true);