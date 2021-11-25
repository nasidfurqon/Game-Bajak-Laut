using System;
namespace GameBajakLaut
{
    class Karakter : Pemain
    {
        public Karakter()
        {
           Console.WriteLine("Pilih Pahlawan yang akan kamu kamu ajak untuk melawan monster");
           Console.WriteLine($"1.{Karakter1} \n2.{Karakter2} \n3.{Karakter3}");
           int pilihan=Convert.ToInt32(Console.ReadLine());
           if(pilihan==1)
           {
               Console.WriteLine($"Kamu memilih {Karakter1} yang memiliki nyawa sebesar {Nyawa}");
               Console.WriteLine($"{Karakter1} memiliki daya rusak {Kerusakan} dan mempunyai senjata {Senjata}");
               Console.WriteLine(" ");
               Console.WriteLine($"1.Lanjut sebagai {Karakter1} \n2.Pilih Karakter Lain");
               int pilih=Convert.ToInt32(Console.ReadLine());
               if(pilih==1)
               { 
                    Console.WriteLine($"Berikut merupakan informasi mengenai monster");
                    Console.ReadKey();
                    Menu menu=new Menu();
                    menu.Menu1();
               }
               if(pilih==2)
               {
                   Karakter karakter=new Karakter();
               }
           }
           if(pilihan==2)
           {
               Console.WriteLine($"Kamu memilih {Karakter2} yang memiliki nyawa sebesar {Nyawa2}");
               Console.WriteLine($"{Karakter2} memiliki daya rusak {Kerusakan2} dan mempunyai senjata {Senjata2}");
                Console.WriteLine(" ");
               Console.WriteLine($"1.Lanjut sebagai {Karakter2} \n2.Pilih Karakter Lain");
               int pilih=Convert.ToInt32(Console.ReadLine());
               if(pilih==1)
               {
                    Console.WriteLine($"Berikut merupakan informasi mengenai monster");
                    Console.ReadKey();
                    Menu menu=new Menu();
                    menu.Menu2();
               }
               if(pilih==2)
               {
                   Karakter karakter=new Karakter();
               }

           }
           if(pilihan==3)
           {
               Console.WriteLine($"Kamu memilih {Karakter3} yang memiliki nyawa sebesar {Nyawa3}");
               Console.WriteLine($"{Karakter3} memiliki daya rusak {Kerusakan3} dan mempunyai senjata {Senjata3}");
                Console.WriteLine(" ");
               Console.WriteLine($"1.Lanjut sebagai {Karakter3} \n2.Pilih Karakter Lain ");
               int pilih=Convert.ToInt32(Console.ReadLine());
               if(pilih==1)
               {
                    Console.WriteLine($"Berikut merupakan informasi mengenai monster");
                    Console.ReadKey();
                    Menu menu=new Menu();
                    menu.Menu3();
               }
               if(pilih==2)
               {
                   Karakter karakter=new Karakter();
               }
           }
        }
    }
}