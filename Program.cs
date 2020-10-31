using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            double nubmer = double.Parse(Console.ReadLine());
            bool cheack = nubmer>0;
            if(cheack){
                System.Console.WriteLine("Ваше число больше нуля");
            } 
            else{
                System.Console.WriteLine("Ваше число меньше нуля");
            }
        }
    }
}
