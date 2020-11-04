using System;

namespace massions_on_the_course_C__main
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            ATM atm1 = new ATM();
            System.Console.Write("Введите имя: ");
            atm1.name = Console.ReadLine();
            System.Console.Write("Введите фамилию: ");
            atm1.surname = Console.ReadLine();
            System.Console.Write("Введите отчество: ");
            atm1.middlename = Console.ReadLine();
            System.Console.WriteLine();
            ATM.Menu();
            
        }
    }
}
