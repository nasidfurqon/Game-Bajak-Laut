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
        
        public string NamaPenjaga {get;set;}
        public int NyawaPenjaga {get;set;}
        public int KerusakanPenjaga {get;set;}
        public string SenjataPenjaga {get;set;}
        public int KegesitanPenjaga {get;set;}
        
        public Musuh()
        {
            NamaMusuh1 ="Kraken";
            SenjataMusuh1="Semprotan Racun";
            NyawaMusuh1=65;
            KerusakanMusuh1=5;
            KegesitanMusuh1=5;

            NamaMusuh2 ="Garuda";
            SenjataMusuh2="Trisula";
            NyawaMusuh2=60;
            KerusakanMusuh2=5;
            KegesitanMusuh2=7;

            NamaPenjaga ="Hydra";
            SenjataPenjaga="Semburan Api";
            NyawaPenjaga=80;
            KerusakanPenjaga=10;
            KegesitanPenjaga=9;
        }
    }

}