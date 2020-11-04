using System;
using System.Threading;
namespace variables
{
    internal class ATM
    {
        //Адрес банкомата
        public const double address = 3213;
        //ФИО
        public string name;
        public string surname;
        public string middlename;
        //Счет
        public  double sumMoneyTenge;
        public  double sumMoneyDollar;
        public double sumMoneyRubl;
        //Значения для методов
        public  bool giveMoney=false;
        public bool takeMoney=false;
        public  bool tradeMoney=false;
        public  bool tradeMoneyDollar=false;
        public  bool tradeMoneyRubl=false;
//Метод для зачесления денег
        public static void TakeMoney()
        {
            ATM sumMoney1 = new ATM();
            double tenge;
            {
                    System.Console.Write("Введите сумму для зачесления: ");
                    tenge = double.Parse(Console.ReadLine());
                    sumMoney1.sumMoneyTenge = sumMoney1.sumMoneyTenge + tenge;
                    System.Console.WriteLine($"Вы зачислили данную сумму: {sumMoney1.sumMoneyTenge} тенге");
                    ATM.quation();
            }
        }

//Метод для выдачи денег
        public static void GiveMoney()  
    {
        ATM sumMoney1 = new ATM();
        ConsoleKeyInfo keyInfo;
        double sumMoney;
            System.Console.WriteLine("Какую сумму вы желаете снять?");
            sumMoney = double.Parse(Console.ReadLine());
            sumMoney1.sumMoneyTenge = sumMoney1.sumMoneyTenge - sumMoney;
            System.Console.WriteLine($"У вас на счету осталось: {sumMoney1.sumMoneyTenge} тенге");
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
//Метод который переводит тенге в рубли или в доллары
     public static void TradeMoney()
        {
            ATM sumMoney1 = new ATM();
            ConsoleKeyInfo keyInfo;
            double tenge;
            
                if(sumMoney1.tradeMoneyDollar == true){
                    System.Console.WriteLine("Какую сумму в тенге вы хотите перевести в долары?");    
                    tenge = double.Parse(Console.ReadLine());
                    sumMoney1.sumMoneyTenge = sumMoney1.sumMoneyTenge - tenge;
                    sumMoney1.sumMoneyDollar += tenge % 0.0023;
                }
                else if(sumMoney1.tradeMoneyRubl == true){
                    System.Console.WriteLine("Какую сумму в тенге вы хотите перевести в долары?");    
                    tenge = double.Parse(Console.ReadLine());
                    sumMoney1.sumMoneyTenge = sumMoney1.sumMoneyRubl- tenge;
                    sumMoney1.sumMoneyRubl = sumMoney1.sumMoneyRubl+ tenge % 0.18;
                }
            else{
                ATM.Menu();
            }
            ATM.quation();
            
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
            atm1.tradeMoney= true;
            System.Console.WriteLine("Перевести в доллары- 1");
            System.Console.WriteLine("Перевести в рубли- 2");
            System.Console.WriteLine();
            ATM.quation();
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
                        Console.ReadKey();
                    }
        }
}
}
