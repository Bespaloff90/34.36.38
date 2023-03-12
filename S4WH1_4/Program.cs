// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
  int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0,11);
    }
Console.WriteLine($"Your random array = {string.Join(";",array)}");

int MaxNumber(int[] a)
{
    int max = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > max)
        {
            max = a[i];
        }

    }
    return max;
}
int MinNumber(int[] b)
{
    int min = b[0];
    for (int i = 1; i < b.Length; i++)
    {
        if (b[i] < min)
        {
            min = b[i];
        }
    }
    return min;
}int Maxnum = MaxNumber(array);
Console.WriteLine($" MAX = {Maxnum}");
int MinNum = MinNumber(array);
Console.WriteLine($" MIN = {MinNum}");
Console.WriteLine($" difference max min   = {Maxnum  - MinNum}");