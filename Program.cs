using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = {1,2,3,4,0,5,6};
            int i=0;
            while (intArray[i]!=0)
            {
                System.Console.WriteLine(intArray[i]);
                i++;
            }
            
        } 
    }
}
