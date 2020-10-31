using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[3];
            System.Console.Write("Введите первое число: ");
            intArray[0] = int.Parse(Console.ReadLine());
            System.Console.Write("Введите второе число: ");
            intArray[1] = int.Parse(Console.ReadLine());
            System.Console.Write("Введите третие число: ");
            intArray[2] = int.Parse(Console.ReadLine());
            System.Console.Write("Числа в обратном порядке: ");
            System.Console.WriteLine($"{intArray[2]}, {intArray[1]}, {intArray[0]}");
        } 
    }
}
