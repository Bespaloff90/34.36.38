// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​5 9 2 3
// ​8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Введите размеры массива:  [y, x]");
int y = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[y, x];
 Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 Console.WriteLine();
 Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>y && b>x)
 
 Console.WriteLine("такого числа нет");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine(c);
 }