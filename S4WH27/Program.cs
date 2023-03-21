// Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("This program allows you to find the sum of the entered numbers");
Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Sum of numbers = {GetSumNums(num)}");
int GetSumNums(int number)
{
    int sum = 0;
    while(number>0) 
    {
        sum+=number%10;
        number/=10;
    }
    return sum;
}