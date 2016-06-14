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
                    int Y;
                    var fib = Console.ReadLine();
                    while (!Int32.TryParse(fib, out Y) || (Convert.ToInt32(fib)>31))
                    {
                        Console.WriteLine("Not a valid number, try again. Enter a number less than 31.");
                        fib = Console.ReadLine();
                    }
                    var fibSeries = FibonacciIterative(Convert.ToInt32(fib));
                    Console.WriteLine(fibSeries);
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    Console.WriteLine("2. secenek secildi, kum saati ekrana yazılacak");
                    Boolean loop = true;
                    while (loop)
                    {
                        Console.WriteLine("1 ile 80 arasında bir sayı giriniz:");
                        int X;
                        var num = Console.ReadLine();
                        while (!Int32.TryParse(num, out X))
                        {
                            Console.WriteLine("Not a valid number, try again.");
                            num = Console.ReadLine();
                        }
                        if (Convert.ToInt32(num) <= 80 && Convert.ToInt32(num) >= 1)
                        {
                            loop = false;
                            PrintHourGlass(Convert.ToInt32(num));
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz giriş, tekrar deneyiniz.");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("3. secenek secildi, il ve hava durumu sorgulanacak");
                    Console.WriteLine("Hava durumu sorgusu için bir il giriniz:");
                    var city = Console.ReadLine();

                    break;
                default:
                    Console.WriteLine("Gecersiz giris.");
                    break;
            }
            Console.ReadLine();

        }
        // iterative fibonacci number calculation
        public static int FibonacciIterative(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        // recursive fibonacci number calculation
        public static int FibonacciSeries(int fib)
        {
            if (fib <= 2)
                return 1;
            return FibonacciSeries(fib - 1) + FibonacciSeries(fib - 2);
        }
        // print main menu on screen
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
        // print hourglass with * and in the given size
        private static void PrintHourGlass(int couter)
        {
            for (int row = 0; row < couter ; row++)
            {
                if (couter % 2 == 0)
                {
                    if (row == couter / 2)
                        row++;
                }
                int starCount = Math.Abs(couter - row * 2 - 1) + 1;
                for (int c = 0; c < couter- starCount; c++)
                    Console.Write(" ");
                for (int c = 0; c < starCount; c++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
    }
}

