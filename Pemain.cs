using System;
namespace GameBajakLaut
{
    class Pemain :Musuh
    {
        public string Karakter1{get;set;}
        public int Nyawa {get;set;}
        public int Kerusakan {get;set;}
        public string Senjata {get;set;}

        public string Karakter2{get;set;}
        public int Nyawa2 {get;set;}
        public int Kerusakan2 {get;set;}
        public string Senjata2 {get;set;}

        public string Karakter3{get;set;}
        public int Nyawa3 {get;set;}
        public int Kerusakan3 {get;set;}
        public string Senjata3 {get;set;}
        public Pemain()
        {
            Karakter1="Jason";
            Senjata="Pedang";
            Nyawa=80;
            Kerusakan=6;

            Karakter2="Lucas";
            Senjata2="Kapak Emas";
            Nyawa2=60;
            Kerusakan2=10;

            Karakter3="Muna";
            Senjata3="Panah";
            Nyawa3=80;
            Kerusakan3=6;
        }
        public void Serang()
        {
            Console.ReadKey();
            while(NyawaMusuh1>0 || NyawaMusuh2>0)
            {   
                Console.WriteLine($"Sisa Nyawa {Karakter1} : {Nyawa}");
                Console.WriteLine("Pilih Salah Satu monster yang akan kamu serang :");
                Console.WriteLine($"1.{NamaMusuh1}, nyawa:({NyawaMusuh1}), kelincahan : {KegesitanMusuh1},Daya rusak{KerusakanMusuh1} "
                +$" \n2.{NamaMusuh2},nyawa:({NyawaMusuh2}), kelincahan : {KegesitanMusuh2}, daya rusak {KerusakanMusuh1} \n3.Keluar");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if (pilih==1)
                {
                    if (NyawaMusuh1<=0)
                    {
                        Console.WriteLine($"{Karakter1} berhasil mengalahkan {NamaMusuh1}");
                        Console.WriteLine($"si {NamaMusuh1} sudah mati");
                    }
                    else
                    {
                        Random random=new Random();
                        int presentaseMenghindar=random.Next(15);
                        if(presentaseMenghindar > KegesitanMusuh1)
                        {
                            Console.WriteLine($"{Karakter1} berhasil menyerangnya dengan {Senjata} dan mengenainya "
                            +$"sehingga  memberikan kerusakan sebesar {Kerusakan}");
                            NyawaMusuh1-=Kerusakan;
                            Console.WriteLine($"nyawa dari {NamaMusuh1} tinggal {NyawaMusuh1}");
                        }
                        if(presentaseMenghindar < KegesitanMusuh2)
                        {
                            Nyawa-=KerusakanMusuh1;
                            Console.Write($"awasss,Si {NamaMusuh1} berhasil menghindar,dia malah menyerang {Karakter1}"
                            +$" nyawa {Karakter1} sekarang hanya tinggal {Nyawa} \n");
                        }
                    }
                }
                if (pilih==2)
                {
                    if (NyawaMusuh2<=0)
                    {
                        Console.WriteLine($"{Karakter1} berhasil mengalahkan {NamaMusuh2}");
                        Console.WriteLine($"si {NamaMusuh2} sudah mati");
                    }
                    else
                    {
                        Random random=new Random();
                        int presentaseMenghindar=random.Next(15);
                        if(presentaseMenghindar > KegesitanMusuh2)
                        {
                            Console.WriteLine($"{Karakter1} berhasil menyerangnya dengan {Senjata} dan mengenainya "
                            +$"sehingga  memberikan kerusakan sebesar {Kerusakan}");
                            NyawaMusuh2-=Kerusakan;
                            Console.WriteLine($"nyawa dari {NamaMusuh2} tinggal {NyawaMusuh2}");

                        }
                        if(presentaseMenghindar < KegesitanMusuh2)
                        {
                            Nyawa-=KerusakanMusuh2;
                            Console.Write($"awasss,Si {NamaMusuh2} berhasil menghindar,dia malah menyerang {Karakter1}"
                            +$" nyawa {Karakter1} sekarang hanya tinggal {Nyawa} \n");
                        }
                    }
                }
                if (pilih==3)
                {
                    Menu menu= new Menu();
                }
                if (NyawaMusuh1==0 && NyawaMusuh2==0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Bajak Laut :'selamat!!,{Karakter1} berhasil mengalahkan {NamaMusuh1} dan {NamaMusuh2}"
                    +$" dengan nyawa yang tersisa {Nyawa}'");
                    Console.ReadKey();
                   Penjaga penjaga =new Penjaga ();
                }
                if(Nyawa==0)
                {
                    Console.WriteLine($"{Karakter1} kalah!!");
                    Console.WriteLine(" ");
                    Console.WriteLine("1.Main Lagi");
                    int pilihan=Convert.ToInt32(Console.ReadLine());
                    if(pilihan==1)
                    {
                        Cerita cerita=new Cerita();
                    }
                }
            }  
            
        }
        public void Serang2()
        {
            Console.ReadKey();
            while(NyawaMusuh1>0 || NyawaMusuh2>0)
            {   
                Console.WriteLine($"Sisa Nyawa {Karakter2} : {Nyawa}");
                Console.WriteLine("Pilih Salah Satu monster yang akan kamu serang :");
                Console.WriteLine($"1.{NamaMusuh1}, nyawa:({NyawaMusuh1}), kelincahan : {KegesitanMusuh1}, daya rusak {KerusakanMusuh1} "
                +$" \n2.{NamaMusuh2},nyawa:({NyawaMusuh2}), kelincahan : {KegesitanMusuh1}, daya rusak {KerusakanMusuh2} \n3.Keluar");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if (pilih==1)
                {
                    if (NyawaMusuh1<=0)
                    {
                        Console.WriteLine($"{Karakter2} berhasil mengalahkan {NamaMusuh1}");
                        Console.WriteLine($"si {NamaMusuh1} sudah mati");
                    }
                    else
                    {
                        Random random=new Random();
                        int presentaseMenghindar=random.Next(15);
                        if(presentaseMenghindar > KegesitanMusuh1)
                        {
                            Console.WriteLine($"{Karakter2} berhasil menyerangnya dengan {Senjata2} dan mengenainya "
                            +$"sehingga  memberikan kerusakan sebesar {Kerusakan2}");
                            NyawaMusuh1-=Kerusakan2;
                            Console.WriteLine($"nyawa dari {NamaMusuh1} tinggal {NyawaMusuh1}");
                        }
                        if(presentaseMenghindar < KegesitanMusuh2)
                        {
                            Nyawa2-=KerusakanMusuh1;
                            Console.Write($"awasss,Si {NamaMusuh1} berhasil menghindar,dia malah menyerang {Karakter2}"
                            +$" nyawa {Karakter2} sekarang hanya tinggal {Nyawa2} \n");
                        }
                    }
                }
                if (pilih==2)
                {
                    if (NyawaMusuh2<=0)
                    {
                        Console.WriteLine($"{Karakter2} berhasil mengalahkan {NamaMusuh2}");
                        Console.WriteLine($"si {NamaMusuh2} sudah mati");
                    }
                    else
                    {
                        Random random=new Random();
                        int presentaseMenghindar=random.Next(15);
                        if(presentaseMenghindar > KegesitanMusuh2)
                        {
                            Console.WriteLine($"{Karakter2} berhasil menyerangnya dengan {Senjata2} dan mengenainya "
                            +$"sehingga  memberikan kerusakan sebesar {Kerusakan2}");
                            NyawaMusuh2-=Kerusakan2;
                            Console.WriteLine($"nyawa dari {NamaMusuh2} tinggal {NyawaMusuh2}");

                        }
                        if(presentaseMenghindar < KegesitanMusuh2)
                        {
                            Nyawa2-=KerusakanMusuh2;
                            Console.Write($"awasss,Si {NamaMusuh2} berhasil menghindar,dia malah menyerang {Karakter2}"
                            +$" nyawa {Karakter2} sekarang hanya tinggal {Nyawa2} \n");
                        }
                    }
                }
                if (pilih==3)
                {
                    Menu menu= new Menu();
                }
                if (NyawaMusuh1==0 && NyawaMusuh2==0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Bajak Laut:'selamat!!,{Karakter2} berhasil mengalahkan {NamaMusuh1} dan {NamaMusuh2}"
                    +$" dengan nyawa yang tersisa {Nyawa2}'");
                    Console.ReadKey();
                   Penjaga penjaga =new Penjaga ();
                }
                if(Nyawa==0)
                {
                    Console.WriteLine($"{Karakter2} kalah!!");
                    Console.WriteLine(" ");
                    Console.WriteLine("1.Main Lagi");
                    int pilihan=Convert.ToInt32(Console.ReadLine());
                    if(pilihan==1)
                    {
                       Cerita cerita=new Cerita();
                    }
                }
            }  
            
        }
        public void Serang3()
        {
            Console.ReadKey();
            while(NyawaMusuh1>0 || NyawaMusuh2>0)
            {   
                Console.WriteLine($"Sisa Nyawa {Karakter3} : {Nyawa}");
                Console.WriteLine("Pilih Salah Satu monster yang akan kamu serang :");
                Console.WriteLine($"1.{NamaMusuh1}, nyawa:({NyawaMusuh1}), kelincahan : {KegesitanMusuh1}, daya rusak {KerusakanMusuh1} "
                +$" \n2.{NamaMusuh2},nyawa:({NyawaMusuh2}), kelincahan : {KegesitanMusuh1}, daya rusak {KerusakanMusuh2} \n3.Keluar");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if (pilih==1)
                {
                    if (NyawaMusuh1<=0)
                    {
                        Console.WriteLine($"{Karakter3} berhasil mengalahkan {NamaMusuh1}");
                        Console.WriteLine($"si {NamaMusuh1} sudah mati");
                    }
                    else
                    {
                        Random random=new Random();
                        int presentaseMenghindar=random.Next(15);
                        if(presentaseMenghindar > KegesitanMusuh1)
                        {
                            Console.WriteLine($"{Karakter3} berhasil menyerangnya dengan {Senjata3} dan mengenainya "
                            +$"sehingga  memberikan kerusakan sebesar {Kerusakan3}");
                            NyawaMusuh1-=Kerusakan3;
                            Console.WriteLine($"nyawa dari {NamaMusuh1} tinggal {NyawaMusuh1}");
                        }
                        if(presentaseMenghindar < KegesitanMusuh2)
                        {
                            Nyawa3-=KerusakanMusuh1;
                            Console.Write($"awasss,Si {NamaMusuh1} berhasil menghindar,dia malah menyerang {Karakter3}"
                            +$" nyawa {Karakter3} sekarang hanya tinggal {Nyawa3} \n");
                        }
                    }
                }
                if (pilih==2)
                {
                    if (NyawaMusuh2<=0)
                    {
                        Console.WriteLine($"{Karakter3} berhasil mengalahkan {NamaMusuh2}");
                        Console.WriteLine($"si {NamaMusuh2} sudah mati");
                    }
                    else
                    {
                        Random random=new Random();
                        int presentaseMenghindar=random.Next(15);
                        if(presentaseMenghindar>KegesitanMusuh2)
                        {
                            Console.WriteLine($"{Karakter3} berhasil menyerangnya dengan {Senjata3} dan mengenainya "
                            +$"sehingga  memberikan kerusakan sebesar {Kerusakan3}");
                            NyawaMusuh2-=Kerusakan3;
                            Console.WriteLine($"nyawa dari {NamaMusuh2} tinggal {NyawaMusuh2}");

                        }
                        if(presentaseMenghindar < KegesitanMusuh2)
                        {
                            Nyawa3-=KerusakanMusuh2;
                            Console.Write($"awasss,Si {NamaMusuh2} berhasil menghindar,dia malah menyerang {Karakter3}"
                            +$" nyawa {Karakter3} sekarang hanya tinggal {Nyawa3} \n");
                        }
                    }
                }
                if (pilih==3)
                {
                    Menu menu= new Menu();
                }
                if (NyawaMusuh1==0 && NyawaMusuh2==0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Bajak Laut :'selamat!!,{Karakter3} berhasil mengalahkan {NamaMusuh1} dan {NamaMusuh2}"
                    +$" dengan nyawa yang tersisa {Nyawa3}'");
                    Console.ReadKey();
                   Penjaga penjaga =new Penjaga ();
                }
                if(Nyawa==0)
                {
                    Console.WriteLine($"{Karakter3} kalah!!");
                    Console.WriteLine(" ");
                    Console.WriteLine("1.Main Lagi");
                    int pilihan=Convert.ToInt32(Console.ReadLine());
                    if(pilihan==1)
                    {
                        Cerita cerita=new Cerita();
                    }
                }
            }  
            
        }
    }
}