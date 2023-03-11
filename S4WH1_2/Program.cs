// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.Clear();
Console.WriteLine("Hello friend! ");
int[] arr = new int[12];
            int k = 0; //sum = 0;
            Random rnd = new Random();
 
            Console.WriteLine("Input array");
            for (int i = 0; i < 12; i++)
            {
                arr[i] = rnd.Next(99, 1000);
                Console.Write("{0} ", arr[i]);
            }
             Console.WriteLine();
            Console.WriteLine("Array in ascending order ");
             Array.Sort(arr);
 
            foreach(int element in arr)
             {
                 Console.Write("{0} ", element);
               if (element % 2 == 0)
                {
                     k++;
                   
                 }
           }
             Console.WriteLine();
             Console.WriteLine("Number of even elements:  {0}", k); 