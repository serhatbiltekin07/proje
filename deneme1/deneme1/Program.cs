using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            string islem;
            Console.WriteLine("Birinci sayıyı giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nToplama---> t");
            Console.WriteLine("Çıkarma--->c");
            Console.WriteLine("Çarpma--->m");
            Console.WriteLine("Bölme--->b");

            Console.WriteLine("İşleminizi seçiniz :");
            islem = Console.ReadLine();

            if (islem == "b")
                if (sayi2 != 0)
                {
                    float sonuc = (float)sayi1 / (float)sayi2;
                    Console.WriteLine("sonuç: {0}", sonuc);
                }
            else 
                {
                    Console.WriteLine("Bölen sıfır olamaz");
                }
            else if (islem == "t")
            {
                Console.WriteLine("sonuç: {0}", sayi1 + sayi2);
            }
            else if (islem == "m")
            {
                Console.WriteLine("sonuç: {0}", sayi1 * sayi2);
            }
            else
            {
                    Console.WriteLine("sonuç: {0}", sayi1 - sayi2);
            }

            Console.ReadKey();  

        }
    }
}
