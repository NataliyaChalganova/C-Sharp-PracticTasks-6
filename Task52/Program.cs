// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
Random rnd = new Random();
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i,j] = rnd.Next(2, 10);
        Console.Write($"{array[i,j]}, ");
    }
    Console.WriteLine();
}


for(int i = 0; i < m; i++)
{   
    int result = 0;
    for(int j = 0; j < n; j++)
    {  
       result += array[j,i]; 
       Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)result/m}");
    }
}
