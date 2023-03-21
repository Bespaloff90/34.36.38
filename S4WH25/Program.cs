//  Напишите цикл, который принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Clear();
Console.WriteLine("This program allows you to raise any given number to any given power. ");
Console.Write("Enter number: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Enter the degree of the number ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"{A} degree of the number {B} = {Pow(A,B)}");


int Pow(int num, int rank)
{
    if(B==0) return 1;

    int result = num;
    for (int i = 2; i <= rank; i++)
    {
        result *= num;
    }
    return result;
}