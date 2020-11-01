using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[6]{1,2,3,4,5,6};
            Array.Reverse(intArray);
            foreach (int i in intArray)
            {
                System.Console.WriteLine(i);
            }
            
        } 
    }
}
