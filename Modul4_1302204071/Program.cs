using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302204071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan.JumlahTigaAngka<float>(13f, 2f, 22f);
        }
    }
    class Penjumlahan
    {
        public static void JumlahTigaAngka <T> (T inputSatu, T inputDua, T inputTiga)
        {
            dynamic tambahSatu = inputSatu;
            dynamic tambahDua = inputDua;
            dynamic tambahTiga = inputTiga; 

            Console.WriteLine(tambahSatu + tambahDua + tambahTiga);     
        }
    }
}
