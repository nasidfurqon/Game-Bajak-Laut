using System;

namespace NewGame
{
    class Cerita
    {
        public Cerita()
        {
            Console.WriteLine("Selamat Datang di Game....");
            Console.Write("siapa namamu : ");
            var nama=Console.ReadLine();
            Console.WriteLine($"Bajak Laut :'Hai {nama},kamu sedang terjebak di Segitiga bermuda'");
            Console.ReadKey();
            Console.WriteLine($"{nama} : 'Segitiga Bermuda?,lalu bagaimana saya bisa keluar?'");
            Console.ReadKey();
            Console.WriteLine($"Bajak Laut:'Kamu bisa keluar dari segitiga bermuda jika kamu berhasil membuka"
            +" portal di samudera Beru'");
            Console.ReadKey();
            Console.WriteLine($"{nama} :'Dimana itu Samudera Beru?'");
            Console.ReadKey();
            Console.WriteLine($"Bajak Laut :'Ambil peta ini,disitu ada petunjuk menuju Samudera Beru"
            +" sebelum kamu sampai ke samudera Beru kamu akan bertemu Monster yang menguasai dua wilayah"
            +" yaitu wilayah air dan udara,setelah kamu mengalahkan 2 monster itu kamu akan sampai ke samudera Beru"
            +" tapi tidak sampai disitu saja,kamu juga akan melawan sang penjaga portal yang sangat kuat'");
            Console.ReadKey();
            Console.WriteLine($"{nama} :'lalu bagaimana saya bisa Kembali ke tempat asalku ?'");
            Console.ReadKey();
            Console.WriteLine($"Bajak Laut:'kalahkan monster monster itu'");
            Console.ReadKey();
            Console.WriteLine($"{nama} :'Lalu bagaimana aku bisa mengalahkan 2 monster itu + penjaganya?'");
            Console.ReadKey();
            Console.WriteLine($"Bajak Laut:'Kamu bisa memilih salah satu dari 3 pahlawan yang akan Membantumu"
            +" 'mereka memiliki kelebihan dan kekurangan masing masing");
            Console.ReadKey();
            Console.WriteLine($"Bajak Laut:'Semoga Berhasil'");
            Console.ReadKey();
        }
    }
}