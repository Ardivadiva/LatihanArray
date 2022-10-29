using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugaslatihan
{
    internal class harihari
    {
        public void Macamhari()
        {
            string[] hari = { "Hari Senin", "Hari Selasa", "Hari Rabu", "Hari Kamis", "Hari Jumat", "Hari Sabtu", "Hari Minggu", };

            Console.WriteLine("Masukkan kunci 1-10 untuk menampilkan hari");

            int days = Convert.ToInt32(Console.ReadLine());

            if (days == 1)
            {
                Console.WriteLine(hari[0]);
            }
            else if (days == 2)
            {
                Console.WriteLine(hari[1]);
            }
            else if (days == 3)
            {
                Console.WriteLine(hari[2]);
            }
            else if (days == 4)
            {
                Console.WriteLine(hari[3]);
            }
            else if (days == 5)
            {
                Console.WriteLine(hari[4]);
            }
            else if (days == 6)
            {
                Console.WriteLine(hari[5]);
            }
            else if (days == 7)
            {
                Console.WriteLine(hari[6]);
            }
            else
            {
                Console.WriteLine("Anda Mendapat Zonk");
            }
            string[] dinoiki = { "Hari Senin", "Hari Selasa", "Hari Rabu", "Hari Kamis", "Hari Jumat", "Hari Sabtu", "Hari Minggu", };
            Console.WriteLine("Masukkan Karakternya Dong");

            char dino = Convert.ToChar(Console.ReadLine());

            if (dino == 'A')
            {
                Console.WriteLine(dinoiki[0]);
            }
            else if (dino == 'B')
            {
                Console.WriteLine(dinoiki[1]);
            }
            else if (dino == 'C')
            {
                Console.WriteLine(dinoiki[2]);
            }
            else if (dino == 'D')
            {
                Console.WriteLine(dinoiki[3]);
            }
            else if (dino == 'E')
            {
                Console.WriteLine(dinoiki[4]);
            }
            else if (dino == 'F')
            {
                Console.WriteLine(dinoiki[5]);
            }
            else if (dino == 'G')
            {
                Console.WriteLine(dinoiki[6]);
            }
            else
            {
                Console.WriteLine("Anda Mendapat Zonk");
            }
        }
    }
}
