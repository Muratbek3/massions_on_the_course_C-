using System;
using System.Threading;
namespace variables
{
    class Program
    {
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите число для сравнения");
            //Запрашиваем число для сравнения у пользователя
            double CompNum = double.Parse(Console.ReadLine());
            //Инициализируем метод и выводим возращаемое значение на экран
            System.Console.WriteLine(CompZero(CompNum));
        } 
        //Метод который принимает значение с плавующей точкой и сравнивает его с нулем и возращает ответ в виде строки
        static string CompZero(double nubmer)
        {
            
            if (0>nubmer){
            return "Число меньше нуля";
            }
            else if(0<nubmer){
            return "Число больше нуля";
            }
            else if (0==nubmer){
            return "Число равно нуля";
            }
         }
        }
    }
    

