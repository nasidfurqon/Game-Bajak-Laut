using System;
namespace GameBajakLaut
{
    class  Menu :Pemain
    {
        
        public void Menu1()
        {
            while(true)
            {
                Console.WriteLine("Informasi Monster");
                Console.WriteLine($"1.Monster Laut \n2.Monster Udara \n3.Serang Monster");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if(pilih==1)
                {
                    MonsterLaut monsterLaut=new MonsterLaut();
                }
                if(pilih==2)
                {
                    MonsterUdara monsterUdara=new MonsterUdara();
                }
                if(pilih==3)
                {
                    Serang();
                }
            }
        }
        public void Menu2()
        {
            while(true)
            {
                Console.WriteLine("Informasi Monster");
                Console.WriteLine($"1.Monster Laut \n2.Monster Udara \n3.Serang Monster");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if(pilih==1)
                {
                    MonsterLaut monsterLaut=new MonsterLaut();
                }
                if(pilih==2)
                {
                    MonsterUdara monsterUdara=new MonsterUdara();
                }
                if(pilih==3)
                {
                    Serang2();
                }
            }
        }
        public void Menu3()
        {
            while(true)
            {
                Console.WriteLine("Informasi Monster");
                Console.WriteLine($"1.Monster Laut \n2.Monster Udara \n3.Serang Monster");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if(pilih==1)
                {
                    MonsterLaut monsterLaut=new MonsterLaut();
                }
                if(pilih==2)
                {
                    MonsterUdara monsterUdara=new MonsterUdara();
                }
                if(pilih==3)
                {
                    Serang3();
                }
            }
        }
    }
}