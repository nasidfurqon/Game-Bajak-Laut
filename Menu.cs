using System;
namespace GameBajakLaut
{
    class  Menu 
    {
        public void Menu1()
        {
            while(true)
            {
                Console.WriteLine("Informasi Monster");
                Console.WriteLine($"1.Monster Laut \n2.Monster Udara ");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if(pilih==1)
                {
                    MonsterLaut monsterLaut=new MonsterLaut();
                }
                if(pilih==2)
                {
                    MonsterUdara monsterUdara=new MonsterUdara();
                }
            }
        }
        public void Menu2()
        {
            while(true)
            {
                Console.WriteLine("Informasi Monster");
                Console.WriteLine($"1.Monster Laut \n2.Monster Udara ");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if(pilih==1)
                {
                    MonsterLaut monsterLaut=new MonsterLaut();
                }
                if(pilih==2)
                {
                    MonsterUdara monsterUdara=new MonsterUdara();
                }
            }
        }
        public void Menu3()
        {
            while(true)
            {
                Console.WriteLine("Informasi Monster");
                Console.WriteLine($"1.Monster Laut \n2.Monster Udara ");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if(pilih==1)
                {
                    MonsterLaut monsterLaut=new MonsterLaut();
                }
                if(pilih==2)
                {
                    MonsterUdara monsterUdara=new MonsterUdara();
                }
            }
        }
    }
}