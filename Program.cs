using System;
using System.Threading;
namespace variables
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //запрашиваем строку у пользователя
            System.Console.WriteLine("Введите пожалуйста слова или предложение");
            string str = Console.ReadLine();
			double StrNumber = StringNumber(str);
			Console.WriteLine(StrNumber);
        } 
        //Метод с параметром строки и возращающий ее длину в виде числа с плавающей точкой
        static double StringNumber(string word)
        {
          return word.Length;
        }
    }
    
}
