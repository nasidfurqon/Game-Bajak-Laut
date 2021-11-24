using System;
namespace GameBajakLaut
{
    class Musuh 
    {
        public string NamaMusuh1 {get;set;}
        public string NamaMusuh2 {get;set;}
        public int NyawaMusuh1 {get;set;}
        public int NyawaMusuh2 {get;set;}

        public int KerusakanMusuh1 {get;set;}
        public int KerusakanMusuh2 {get;set;}
        public string SenjataMusuh1 {get;set;}
        public string SenjataMusuh2 {get;set;}
        public int KegesitanMusuh1 {get;set;}
        public int KegesitanMusuh2 {get;set;}
        public Musuh()
        {
            NamaMusuh1 ="Kraken";
            SenjataMusuh1="Semprotan Racun";
            NyawaMusuh1=20;
            NyawaMusuh2=16;
            KerusakanMusuh1=4;
            KegesitanMusuh1=5;
            NamaMusuh2 ="Garuda";
            SenjataMusuh2="Trisula";
            KerusakanMusuh2=2;
            KegesitanMusuh2=7;
        }
    }

}