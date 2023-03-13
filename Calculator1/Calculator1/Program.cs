using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATOR MENU");
            Console.WriteLine("--------------------\n");
            Console.WriteLine("Menu: ");
            Console.WriteLine("\t1. Penjumlahan");
            Console.WriteLine("\t2. Pengurangan");
            Console.WriteLine("\t3. Perkalian");
            Console.WriteLine("\t4. Pembagian");
            string ulang;
            
            do
            {
                Console.Write("Masukkan pilihan operasi yang ingin dilakukan: ");
                int PilOperasi = Convert.ToInt32(Console.ReadLine());
                if (PilOperasi <=0 || PilOperasi > 4)
                {
                    Console.WriteLine("Pilihan tidak ada");
                }
                else
                {
                    Console.Write("Masukkan angka pertama: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan angka kedua: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    switch (PilOperasi)
                    {
                        case 1:
                            int jumlah = num1 + num2;
                            Console.WriteLine($"Hasil penjumlahan {num1} + {num2} = " + jumlah);
                            break;
                        case 2:
                            int kurang = num1 - num2;
                            Console.WriteLine($"Hasil pengurangan {num1} - {num2} = " + kurang);
                            break;
                        case 3:
                            int kali = num1 * num2;
                            Console.WriteLine($"Hasil perkalian {num1} * {num2} = " + kali);
                            break;
                        case 4:
                            decimal bagi = Convert.ToDecimal(num1) / Convert.ToDecimal(num2);
                            Console.WriteLine($"Hasil pembagian {num1} / {num2} = " + bagi);
                            break;                        
                    }
                }
                                           
                Console.Write("Apakah anda ingin melakukan perhitungan lagi? [Y/N] :  ");
                ulang = Console.ReadLine();
            } while (ulang == "Y");           
        }
    }
}
