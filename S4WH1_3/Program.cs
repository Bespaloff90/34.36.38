//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Hello friend! ");
int[] arr = new int[5];
int k = 0, sum = 0;
Random rnd = new Random();

Console.WriteLine("Input array");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 10);
       
}

for (int i = 0; i < arr.Length; i++)
{
        Console.Write("{0} ", arr[i]);
    if (arr[i] % 2 != 0)
    {
        k++;
        sum =sum+ arr[i];
    }
   
}
Console.WriteLine();
Console.WriteLine("Number of odd elements {0}, sum of odd elements {1} ", k, sum);