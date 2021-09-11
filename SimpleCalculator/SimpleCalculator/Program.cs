using System;

namespace SimpleCalculator
{
    public class Program
    {
/*----------------------------Start------------------------*/
        public static void Start()
        {
    
            string sayi1; 
            sayi1 = "";
            
            startlocation: Console.WriteLine("İlk sayıyı giriniz: ");
            sayi1 = Console.ReadLine();
            while (sayi1 == "")
            {
                Console.Clear();
                Console.WriteLine("Bir değer girmelisiniz!");
                goto startlocation;
            }

            string operator1, sayi2;

            sayi2 = "";
            int toplam;
            string quitkey;
            Console.WriteLine("Isleminizi seciniz: (orn:+,-,*,/");
            operator1 = Console.ReadLine();
            while (operator1 == "+")
            {
                Console.WriteLine("İkinci sayıyı giriniz:");
                sayi2 = Console.ReadLine();
                toplam = Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2);
                Console.WriteLine("Toplama işleminin sonucu: " + toplam);
                while (toplam == Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2))
                {

                    Console.WriteLine("Başka işlem yapmak için herhangi bir tuşa basın ya da çıkmak için q ya basın");
                    quitkey = Console.ReadLine();
                    while (quitkey != "q")
                    {
                        Console.Clear();
                        Start();
                    }
                    quit();
                }
            }
            while (operator1 == "-")
            {
                Console.WriteLine("İkinci sayıyı giriniz:");
                sayi2 = Console.ReadLine();
                toplam = Convert.ToInt32(sayi1) - Convert.ToInt32(sayi2);
                Console.WriteLine("Çıkarma işleminin sonucu: " + toplam);
                while (toplam == Convert.ToInt32(sayi1) - Convert.ToInt32(sayi2))
                {

                    Console.WriteLine("Başka işlem yapmak için herhangi bir tuşa basın ya da çıkmak için q ya basın");
                    quitkey = Console.ReadLine();
                    while (quitkey != "q")
                    {
                        Console.Clear();
                        Start();
                    }
                    quit();
                }
            }
            while (operator1 == "*")
            {
                Console.WriteLine("İkinci sayıyı giriniz:");
                sayi2 = Console.ReadLine();
                toplam = Convert.ToInt32(sayi1) * Convert.ToInt32(sayi2);
                Console.WriteLine("Çarpma işleminin sonucu: " + toplam);
                while (toplam == Convert.ToInt32(sayi1) * Convert.ToInt32(sayi2))
                {

                    Console.WriteLine("Başka işlem yapmak için herhangi bir tuşa basın ya da çıkmak için q ya basın");
                    quitkey = Console.ReadLine();
                    while (quitkey != "q")
                    {
                        Console.Clear();
                        Start();
                    }
                    quit();
                }
            }
            while (operator1 == "/")
            {
                Console.WriteLine("İkinci sayıyı giriniz:");
                sayi2 = Console.ReadLine();
                toplam = Convert.ToInt32(sayi1) / Convert.ToInt32(sayi2);
                Console.WriteLine("Bölme işleminin sonucu: " + toplam);
                while (toplam == Convert.ToInt32(sayi1) / Convert.ToInt32(sayi2))
                {

                    Console.WriteLine("Başka işlem yapmak için herhangi bir tuşa basın ya da çıkmak için q ya basın");
                    quitkey = Console.ReadLine();
                    while (quitkey != "q")
                    {
                        Console.Clear();
                        Start();
                    }
                    quit();
                }
            }
            /*Hatalı Operator Girilirse*/

            wrongoperator();

        }


/*----------------------Hatalı Operator--------------------*/
        static void wrongoperator()
        {
            
            Console.WriteLine("Hatalı Operatör Girdiniz!");
            Start();
        }


/*---------------------------Quit--------------------------*/
        static void quit()
        {
            Console.WriteLine("Çıkış yapılıyor...");
            Environment.Exit(0);
        }


/*--------------------------Main---------------------------*/
        static void Main(string[] args)
        {
            string b1 = "";
            Console.WriteLine("Başlamak için 'basla' yazın:");
            b1 = Console.ReadLine();
            if(b1 == "basla")
            {
            Start();
            }
            Console.WriteLine("'Basla' yazmadın!");
            quit();
        }
    }
}
