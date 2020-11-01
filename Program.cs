using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[6]{1,2,3,4,5,6};
            
            for (int i = 1; i < intArray.Length-1; i++)           
            {
                System.Console.WriteLine(intArray[i]);
            }
            
        } 
    }
}
