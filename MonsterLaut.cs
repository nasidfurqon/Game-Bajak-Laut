using System;
namespace GameBajakLaut
{
    class MonsterLaut : Musuh
    {
        public MonsterLaut()
        {
            Console.WriteLine($"Monster ini dijuluki {NamaMusuh1},dan memiliki nyawa {NyawaMusuh1}");
            Console.WriteLine($"Monster ini Menyerang Musuhnya dengan {SenjataMusuh1} yang memiliki kerusakan sebesar {KerusakanMusuh1}"
            +$" dan memiliki kegesitan sebesar {KegesitanMusuh1}");
        }
    }
}