using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classobj
{
    public class Program
        {
            public static void Main()
            {
            Mobil mobil1 = new Mobil();
            
            mobil1.Warna = "Hitam";
            mobil1.JumlahPintu = 4;
            mobil1.Merk = "Jeep";
            mobil1.Model = "Rubicon";
            mobil1.TahunKeluar = 2018;
            
            mobil1.Gas(120);
            mobil1.Klakson("poom");
            mobil1.Tampilkaninfo();



            Console.Write("Press <Q> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Q) { }
        }
        }

       

        }
 
