using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = DisplayMenu();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. secenek secildi, fibonacci sayısı hesaplanacak");
                    Console.WriteLine("Fibonacci sayisi hesaplanacak sayiyi giriniz:");
                    var fib = Console.ReadLine();
                    var fibSeries = FibonacciSeries(Convert.ToInt32(fib));
                    Console.WriteLine(fibSeries);
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    Console.WriteLine("2. secenek secildi, kum saati ekrana yazılacak");
                    Boolean loop = true;
                    while (loop)
                    {
                        Console.WriteLine("1 ile 80 arasında bir sayı giriniz:");
                        var num = Console.ReadLine();
                        if (Convert.ToInt32(num) <= 80 && Convert.ToInt32(num) >= 1)
                        {
                            loop = false;
                            printHourGlass(Convert.ToInt32(num));
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz giriş, tekrar deneyiniz.");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("3. secenek secildi, il ve hava durumu sorgulanacak");

                    break;
                default:
                    Console.WriteLine("Gecersiz giris.");
                    break;
            }
            Console.ReadLine();

        }

        public static int FibonacciSeries(int fib)
        {
            if (fib <= 1)
                return fib;
            return FibonacciSeries(fib - 1) + FibonacciSeries(fib - 2);
        }
        public static int DisplayMenu()
        {
            Console.WriteLine("Istenen islem icin menudeki ilgili sayiyi tuslayiniz.");
            Console.WriteLine();
            Console.WriteLine("1. Fibonacci Sayisi Hesaplanması");
            Console.WriteLine("2. Kum Saati Gösterimi");
            Console.WriteLine("3. Dünya'da Il ve Hava Durumu Sorgulama");
            Console.WriteLine("Ctrl C, cikis");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }
        public static void printHourGlass(int hour)
        {
            int temp;
            int line;
            int stars;
            int lline; // 
            Boolean way= false; // down
            Boolean checkPoint = false;
            temp = hour;
            line = 0;
            while (checkPoint != true)
            {
                if (way == false)
                {
                    stars = -2; 
                    lline = +1;
                    way = true;
                }
                else
                { 
                    stars = +2;
                    lline = -1;
                    checkPoint = true;
                    temp = temp + stars;
                    line = line + lline;
                }
                while (temp > 0 && temp <=hour)
                {
                    
                    for (int i = 0; i < line; i++)
                    {
                        Console.Write(" ");
                    }
                    for (int i = 0; i < temp; i++)
                    {
                        Console.Write("*");
                    }
                    for (int i = 0; i < line; i++)
                    {
                        Console.Write(" ");
                    }
                    temp = temp + stars;
                    line = line + lline;
                    Console.WriteLine();

                }
                
            }
            Console.WriteLine("Kum Saatinin Sonu");
        }
        
        

    }
}

