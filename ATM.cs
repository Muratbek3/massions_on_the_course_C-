using System;
using System.Threading;
namespace massions_on_the_course_C__main
{
    public class ATM
    {
        //Адрес банкомата
         const double address = 3213;
        //ФИО
         public string name;
         public string surname;
         public string middlename;
        //Счет
        static double sumMoneyTenge;
        static double sumMoneyDollar;
        static double sumMoneyRubl;
        //Значения для методов
            bool giveMoney=false;
         bool takeMoney=false;
          bool tradeMoney=false;
          bool tradeMoneyDollar=false;
          bool tradeMoneyRubl=false;
//Метод для зачесления денег
        public static void TakeMoney()
        {
            ATM sumMoney1 = new ATM();
            double tenge;
            {
                    System.Console.Write("Введите сумму для зачесления: ");
                    tenge = double.Parse(Console.ReadLine());
                    ATM.sumMoneyTenge += ATM.sumMoneyTenge + tenge;
                    System.Console.WriteLine($"Вы зачислили данную сумму: {ATM.sumMoneyTenge} тенге");
                    ATM.quation();
            }
        }

//Метод для выдачи денег
        public static void GiveMoney()  
    {
        ATM sumMoney1 = new ATM();
        double sumMoney0=0;
            System.Console.WriteLine("Какую сумму вы желаете снять?");
            sumMoney0 = double.Parse(Console.ReadLine());
            if(sumMoney0<=ATM.sumMoneyTenge)
            {
            ATM.sumMoneyTenge = ATM.sumMoneyTenge - sumMoney0;
            System.Console.WriteLine($"У вас на счету осталось: {ATM.sumMoneyTenge} тенге");
            ATM.quation();
            }
            else{
                System.Console.WriteLine("Недостаточно средст на счету");
                ATM.quation();
                }
    }
//Метод который переводит тенге в рубли или в доллары
     public static void TradeMoney()
        {
            ATM sumMoney1 = new ATM();
            ConsoleKeyInfo keyInfo;
            double tenge;
            
                System.Console.WriteLine("Хотите перевести деньги в долларах или рублях");
                System.Console.WriteLine("Доллар-1");
                System.Console.WriteLine("Рубль-2");
                keyInfo = Console.ReadKey();
                if(keyInfo.Key == ConsoleKey.D1){
                    System.Console.WriteLine("Какую сумму в тенге вы хотите перевести в доллары?");    
                    tenge = double.Parse(Console.ReadLine());
                    if(tenge<=ATM.sumMoneyTenge){
                    ATM.sumMoneyTenge = ATM.sumMoneyTenge - tenge;
                    
                    ATM.sumMoneyDollar = tenge % 0.0023;
                    System.Console.WriteLine($"На счету осталось в тенге: {ATM.sumMoneyTenge} тенге");
                    System.Console.WriteLine($"На счету осталось в рублях: {ATM.sumMoneyDollar} рублей");
                    ATM.quation();
                    }
                    else{
                        System.Console.WriteLine("Недостаточно средст на счету");
                        ATM.quation();
                    }
                }
                else if(keyInfo.Key == ConsoleKey.D2){
                    System.Console.WriteLine("Какую сумму в тенге вы хотите перевести в рубли?");    
                    tenge = double.Parse(Console.ReadLine());
                    if(tenge>=ATM.sumMoneyTenge){
                    ATM.sumMoneyTenge = ATM.sumMoneyRubl- tenge;
                    ATM.sumMoneyRubl = ATM.sumMoneyRubl+ tenge % 0.18;
                    System.Console.WriteLine($"На счету осталось в тенге: {ATM.sumMoneyTenge} тенге");
                    System.Console.WriteLine($"На счету осталось в рублях: {ATM.sumMoneyRubl} рублей");
                    ATM.quation();
                    }
                    else{
                        System.Console.WriteLine("Недостаточно средст на счету");
                        ATM.quation();
                    }
                }
            else{
                ATM.quation();
            }
            
            
            }
            public static void Menu(){
                ConsoleKeyInfo keyInfo;
                ATM atm1 = new ATM();
            Console.WriteLine("Зачислеть деньги- 1");
            Console.WriteLine("Снять деньги- 2");
             Console.WriteLine("Обменять валюты- 3");
             System.Console.WriteLine();
            keyInfo = Console.ReadKey();
            System.Console.WriteLine();
            if(keyInfo.Key == ConsoleKey.D1){
            ATM.TakeMoney();
            }
            else if(keyInfo.Key == ConsoleKey.D2){
            atm1.giveMoney= true;    
            ATM.GiveMoney();
            }
            else if(keyInfo.Key == ConsoleKey.D3){
            ATM.TradeMoney();
            
            }
       

    }
     public static void quation(){
            ConsoleKeyInfo keyInfo;
            System.Console.WriteLine("Хотите ли совершить еще одну операцию?");
                    System.Console.WriteLine("Да-1");
                    System.Console.WriteLine("Нет-2");
                    System.Console.WriteLine();
                    keyInfo = Console.ReadKey();
                    System.Console.WriteLine();
                    if(keyInfo.Key == ConsoleKey.D1){
                        ATM.Menu();
                    }
                    else if(keyInfo.Key == ConsoleKey.D2){
                        
                    }
        
                }
            }
        }

