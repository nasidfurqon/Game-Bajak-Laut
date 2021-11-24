using System;
namespace GameBajakLaut
{
    class MonsterUdara :Musuh
    {
        public MonsterUdara()
        {
            Console.WriteLine($"Monster ini dijuluki {NamaMusuh2},dan memiliki nyawa {NyawaMusuh2}");
            Console.WriteLine($"Monster ini Menyerang Musuhnya dengan {SenjataMusuh2} yang memiliki kerusakan sebesar {KerusakanMusuh2}"
            +$" dan memiliki kegesitan sebesar {KegesitanMusuh2}");
        }
    }
}