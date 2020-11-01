using System;
using System.Threading;
namespace variables
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;

            System.Console.WriteLine("Что бы начать антивирусную проверку нажмите Enter");
            keyInfo = Console.ReadKey();
           if(keyInfo.Key == ConsoleKey.Enter){
               for (int i = 0; i < 10; i++)
               {
                   Console.Clear();
                   System.Console.WriteLine("Проверка на вирусы");
                    Thread.Sleep(100);
                   Console.Clear();
                   System.Console.WriteLine("Проверка на вирусы.");
                   Thread.Sleep(100);
                   Console.Clear();
                   System.Console.WriteLine("Проверка на вирусы..");
                   Thread.Sleep(100);
                   Console.Clear();
                   System.Console.WriteLine("Проверка на вирусы...");
                   Thread.Sleep(100);
                   Console.Clear();
               }
               System.Console.WriteLine("Проверка на вирусы...");
                    
                
                
               System.Console.WriteLine("Отлично! Зеленый уровень возможности заражения компьютера!");
           }
           else{
               System.Console.WriteLine("Внимание! Красный уровень возможности заражения компьютера!");
           }
           
        } 
        
    }
    
}
