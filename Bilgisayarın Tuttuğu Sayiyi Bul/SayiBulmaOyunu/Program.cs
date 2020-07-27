using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sayi, hak = 5;

            Console.WriteLine("ZORLUK DERECESİ SEÇİNİZ (1-3):");
            Console.WriteLine("1)KOLAY (1-10)");
            Console.WriteLine("2)ORTA (1-50)");
            Console.WriteLine("3)ZOR (1-100)");

            int secenek = int.Parse(Console.ReadLine());
            switch (secenek)
            {
                // KOLAY
                case 1:
                    {
                        sayi = rnd.Next(1, 11);
                        do
                        {
                            Console.Write("Tahmin : ");
                            int tahmin = int.Parse(Console.ReadLine());
                            if (tahmin > sayi)
                            {
                                hak--;
                                if (hak == 0)
                                {
                                    Console.WriteLine("Hakkiniz Bitti");
                                    break;
                                }
                                Console.WriteLine("AZALT!");
                            }
                            else if (tahmin < sayi)
                            {
                                hak--;
                                if (hak == 0)
                                {
                                    Console.WriteLine("Hakkiniz Bitti");
                                    break;
                                }
                                Console.WriteLine("ÇOĞALT!");
                            }
                            else if (tahmin == sayi)
                            {
                                Console.WriteLine("BİLDİN!");
                                break;
                            }
                        } while (hak > 0);

                        break;
                    }

                // ORTA
                case 2:
                    {
                        sayi = rnd.Next(1, 51);
                        do
                        {
                            Console.Write("Tahmin : ");
                            int tahmin = int.Parse(Console.ReadLine());
                            if (tahmin > sayi)
                            {
                                hak--;
                                if (hak == 0)
                                {
                                    Console.WriteLine("Hakkiniz Bitti");
                                    break;
                                }
                                Console.WriteLine("AZALT!");
                            }
                            else if (tahmin < sayi)
                            {
                                hak--;
                                if (hak == 0)
                                {
                                    Console.WriteLine("Hakkiniz Bitti");
                                    break;
                                }
                                Console.WriteLine("ÇOĞALT!");
                            }
                            else if (tahmin == sayi)
                            {
                                Console.WriteLine("BİLDİN!");
                                break;
                            }
                        } while (hak > 0);

                        break;
                    }

                // ZOR
                case 3:
                    {
                        sayi = rnd.Next(1, 101);
                        do
                        {
                            Console.Write("Tahmin : ");
                            int tahmin = int.Parse(Console.ReadLine());
                            if (tahmin > sayi)
                            {
                                hak--;
                                if (hak == 0)
                                {
                                    Console.WriteLine("Hakkiniz Bitti");
                                    break;
                                }
                                Console.WriteLine("AZALT!");
                            }
                            else if (tahmin < sayi)
                            {
                                hak--;
                                if (hak == 0)
                                {
                                    Console.WriteLine("Hakkiniz Bitti");
                                    break;
                                }
                                Console.WriteLine("ÇOĞALT!");
                            }
                            else if (tahmin == sayi)
                            {
                                Console.WriteLine("BİLDİN!");
                                break;
                            }
                        } while (hak > 0);


                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}