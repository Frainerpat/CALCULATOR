using System;
using System.Runtime.CompilerServices;

namespace Valik
{
    class Program
    {
        static void Main(string[] arg)
        {
            /*string data;
            Console.WriteLine("Введите псевдоним");
            data = Console.ReadLine();
            Console.WriteLine("Добро пожаловать " + data); */

            /*int a = 3;
            int b = 4;
            string c = "6";
            Console.WriteLine(c + b +a); */

            /* string z = "3";
            string x = "4";
            int r = Convert.ToInt32(z);
            int v = Convert.ToInt32(x);
            Console.WriteLine(r+v);
            Console.WriteLine(z+x); */

            /*Console.WriteLine("введите первое число");
            string date;
            date = Console.ReadLine();
            int a = Convert.ToInt32(date);
            Console.WriteLine("введите второе число");
            string l;
            l = Console.ReadLine();
            int b = Convert.ToInt32(l);
            Console.WriteLine("сумма чисел = " + a + b);*/

            /*string a = "1,9";
            double z = Convert.ToDouble(a);
            Console.WriteLine(z);*/

            /*Console.WriteLine("Добро пожаловать в программу для выведения суммы и произведения трёх чисел");
            Console.WriteLine("Введите первое числ0");
            string a = Console.ReadLine();
            int v = Convert.ToInt32(a);
            Console.WriteLine("Введите второе число");
            string c = Console.ReadLine();
            int b = Convert.ToInt32(c);
            Console.WriteLine("Введите третье число");
            string s = Console.ReadLine();
            int d = Convert.ToInt32(s);
            Console.WriteLine("Ваша сумма чисел равна:" + (v + b + d));
            Console.WriteLine("Ваше произведение чисел равно:" + (v * b * d));*/

            /*Console.WriteLine("Добро пожаловать в конвертатор валют(рубли пмр - доллар)");
            Console.WriteLine("16,35 RUP - 1 USD");
            Console.WriteLine("Введите количество рублей пмр");
            string a = Console.ReadLine();
            decimal s = Convert.ToDecimal(a);
            decimal oneDollar = 0.0611620m;
            decimal result = Math.Round(s * oneDollar, 2);
            Console.WriteLine("Результат:" + result + " USD");*/

            /*bool infected = false;
            if (infected)
            { 
                Console.WriteLine("Персонаж заражён");
            }
            else
            {
                Console.WriteLine("Персонаж не заражён");
            }*/

            /*string a;
            a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            if (b % 2 == 0)
            {
                Console.WriteLine("чётно");
            }
            else
            {
                Console.WriteLine("нечётно");
            }*/

            /*bool infected = false;
            if (infected)
            {
                Console.WriteLine("заражён");
            }
            else
            {
                Console.WriteLine("здрав");
            }*/
            /*
            int c = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            int otkluchka = c;
            int poteriakrovi = v;
            bool krovotechenie = poteriakrovi > 0;
            bool bessoznanie = otkluchka > 0 ;

            if (krovotechenie || bessoznanie)
            {
                Console.WriteLine("смерть");
            }
            */
            
            /*Console.WriteLine("Добро пожаловать в калькулятор");
            Console.WriteLine("Введите первое число");
            int pervoechislo = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите *, /, + или -");
            string oprachia = Console.ReadLine();
            Console.WriteLine("Введите 2 число");
            int vtoroechislo = int.Parse(Console.ReadLine());
            switch (oprachia)
            {
                case "-":
                    Console.WriteLine(pervoechislo - vtoroechislo);
                    break;
                case "+":
                    Console.WriteLine(pervoechislo + vtoroechislo);
                    break;
                case "*":
                    Console.WriteLine(pervoechislo * vtoroechislo);
                    break;
                case "/":
                    Console.WriteLine(pervoechislo / vtoroechislo);
                    break;
            }*/
            
            Console.WriteLine("Добро пожаловать в калькулятор");
            Console.WriteLine("Введите первое число");
            int pervoechislo = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите *, /, + или -");
            string oprachia = Console.ReadLine();
            Console.WriteLine("Введите 2 число");
            int vtoroechislo = int.Parse(Console.ReadLine());
            if (oprachia == "+")
            {
                Console.WriteLine(pervoechislo + vtoroechislo);
            }
            if (oprachia == "-")
            {
                Console.WriteLine(pervoechislo - vtoroechislo);
            }
            if (oprachia == "*")
            {
                Console.WriteLine(pervoechislo * vtoroechislo);
            }
            if (oprachia == "/")
            {
                Console.WriteLine(pervoechislo / vtoroechislo);
            }
            

        }
    }
}

