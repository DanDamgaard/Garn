using System;
using System.Collections.Generic;
using System.Text;

namespace garnClass
{
    public class Vare
    {
        private string navn;
        private int pris;
        private string[] materialeListe;

        public Vare(string navn, int pris, string[] materialeListe)
        {
            this.navn = navn;
            this.pris = pris;
            this.materialeListe = materialeListe;
        }

        public string retunerNavn()
        {
            return navn;
        }

        public void redigerNavn(string nyNavn)
        {
            navn = nyNavn;
        }

        public void redigerPris(int nyPris)
        {
            pris = nyPris;
        }

        public int retunerPris()
        {
            return pris;
        }

        public string[] retunerMaterialeListe()
        {
            return materialeListe;
        }
    }
}
