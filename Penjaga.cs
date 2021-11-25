using System;
namespace GameBajakLaut
{
    class Penjaga : Pemain
    {
        public void Penjaga1()
        {
            Console.WriteLine($"{Karakter1} Berhasil Menuntunmu sampai ke Samudera Beru,selanjutnya kalahkan"
            +" Penjaga itu agar kamu bisa keluar dari Segitiga Bermuda");
            Console.ReadKey();
            Console.WriteLine($"Sebagai Hadiah,Disini Nyawa Dari {Karakter1} kembali pulih menjadi {Nyawa}");
            Console.WriteLine($"Disini {Karakter1} juga bisa melakukan regen Sebanyak 5 kali");
            Console.ReadKey();
            while(true)
            {
                Console.WriteLine("1.Informasi Si Penjaga \n2.Serang si Penjaga");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if(pilih==1)
                {
                    Console.WriteLine($"Penjaga ini biasa di panggil dengan julukan {NamaPenjaga} yang memiliki nyawa sebesar {NyawaPenjaga}");
                    Console.WriteLine($"{NamaPenjaga} Monster ini Menyerang Musuhnya dengan {SenjataPenjaga} yang memiliki"
                    +$"kerusakan sebesar {KerusakanPenjaga} dan memiliki kegesitan sebesar {KegesitanPenjaga}");
                }
                if(pilih==2)
                {
                    SerangPenjaga1();
                }
            }
        }
        public void Penjaga2()
        {
            Console.WriteLine($"{Karakter2} Berhasil Menuntunmu sampai ke Samudera Beru,selanjutnya kalahkan"
            +" Penjaga itu agar kamu bisa keluar dari Segitiga Bermuda");
            Console.ReadKey();
            Console.WriteLine($"Sebagai Hadiah,Disini Nyawa Dari {Karakter2} kembali pulih menjadi {Nyawa2}");
            Console.WriteLine($"Disini {Karakter2} juga bisa melakukan regen Sebanyak 5 kali");
            Console.ReadKey();

            while(true)
            {
                Console.WriteLine("1.Informasi Si Penjaga \n2.Serang si Penjaga");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if(pilih==1)
                {
                    Console.WriteLine($"Penjaga ini biasa di panggil dengan julukan {NamaPenjaga} yang memiliki nyawa sebesar {NyawaPenjaga}");
                    Console.WriteLine($"{NamaPenjaga} Monster ini Menyerang Musuhnya dengan {SenjataPenjaga} yang memiliki"
                    +$"kerusakan sebesar {KerusakanPenjaga} dan memiliki kegesitan sebesar {KegesitanPenjaga}");
                }
                if(pilih==2)
                {
                    SerangPenjaga2();
                }
            }
        }
        public void Penjaga3()
        {
            Console.WriteLine($"{Karakter3} Berhasil Menuntunmu sampai ke Samudera Beru,selanjutnya kalahkan"
            +" Penjaga itu agar kamu bisa keluar dari Segitiga Bermuda");
            Console.ReadKey();
            Console.WriteLine($"Sebagai Hadiah,Disini Nyawa Dari {Karakter3} kembali pulih menjadi {Nyawa3}");
            Console.WriteLine($"Disini {Karakter3} juga bisa melakukan regen Sebanyak 5 kali");
            Console.ReadKey();
            while(true)
            {
                Console.WriteLine("1.Informasi Si Penjaga \n2.Serang si Penjaga");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if(pilih==1)
                {
                    Console.WriteLine($"Penjaga ini biasa di panggil dengan julukan {NamaPenjaga} yang memiliki nyawa sebesar {NyawaPenjaga}");
                    Console.WriteLine($"{NamaPenjaga} Monster ini Menyerang Musuhnya dengan {SenjataPenjaga} yang memiliki"
                    +$"kerusakan sebesar {KerusakanPenjaga} dan memiliki kegesitan sebesar {KegesitanPenjaga}");
                }
                if(pilih==2)
                {
                    SerangPenjaga3();
                }
            }
        }
    }
}