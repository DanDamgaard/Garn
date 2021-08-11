using System;
using System.Collections.Generic;
using System.Text;

namespace garnClass
{
    public class Materialer
    {
        private string navn;
        private int antal;
        private int pris;

        public Materialer(string navn, int antal, int pris)
        {
            this.navn = navn;
            this.antal = antal;
            this.pris = pris;
        }

        public string retunerName()
        {
            return navn;
        }

        public int retunerAntal()
        {
            return antal;
        }
        public int retunerPris()
        {
            return pris;
        }

        public void redigerPris(int nyPris)
        {
            pris = nyPris;
        }
    }
}
