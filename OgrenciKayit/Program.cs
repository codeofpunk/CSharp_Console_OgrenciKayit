using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciKayit
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi, soyadi, sehir;

            Console.WriteLine("*** Öğrenci Kayıt Sistemi ***");

        ogrenci_kayit:

            RenkVer();
            Console.WriteLine("--- Yeni Kayıt ---");
            RenkReset();

            RenkVer();
            Console.Write("Öğrenci Adı: ");
            RenkReset();
            adi = Convert.ToString(Console.ReadLine());

            RenkVer();
            Console.Write("Öğrenci SoyAdı: ");
            RenkReset();
            soyadi = Convert.ToString(Console.ReadLine());

            RenkVer();
            Console.Write("Yaşadığınız Şehir: ");
            RenkReset();
            sehir = Convert.ToString(Console.ReadLine());

            if (adi == "" || soyadi == "" || sehir == "")
            {
                Console.WriteLine();
                Console.WriteLine("Lütfen bütün alanları doldurun!");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine(adi + " " + soyadi + " adlı öğrencinin kayıdı başarılı şekilde " + sehir + " iline yapıldı.");
                Console.WriteLine();
            }

            goto ogrenci_kayit;

            Console.ReadLine();
        }

        static void RenkVer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        static void RenkReset()
        {
            Console.ResetColor();
        }
    }
}
