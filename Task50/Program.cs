// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк двумерного массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива:");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомое в массиве число: "); 
int number=Convert.ToInt32 (Console.ReadLine());
int [,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
Console.WriteLine(CheckNumberIn(number, array));

void FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(1,10);
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3}\t");
        Console.WriteLine();  
    }
}

{ 
    foreach (int el in array)   
    Console.WriteLine(); 
} 
bool CheckNumberIn(int number, int[,] array) 
{ 
    bool find = false; 
    foreach (int el in array) 
    { 
        if (el == number) 
        { 
            find = true; 
            break; 
        } 
    } 
    return find; 
} 
