using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace garnClass
{
    public class Afdeling
    {
        private Ansat[] ansat;
        private string lokation;
        private string arbejdsOmråde;
        private bool admin;
        private string navn;

        public Afdeling(Ansat[] ansat, string lokation, string arbejdsOmråde, bool admin, string navn)
        {
            this.ansat = ansat;
            this.lokation = lokation;
            this.arbejdsOmråde = arbejdsOmråde;
            this.admin = admin;
            this.navn = navn;
        }
        public void fyr(string navn)
        {
            int pos = 0;
            while (pos < ansat.Length)
            {
                if (ansat[pos].retunerNavn() == navn)
                {
                    ansat = ansat.Where(val => val != ansat[pos]).ToArray();
                }
            }

        }


        public string retunerNavn()
        {
            return navn;
        }

        public string retunerArbejdsOmråde()
        {
            return arbejdsOmråde;
        }

        public void hyr(Ansat nyAnsat)
        {
            
            ansat = (ansat ?? Enumerable.Empty<Ansat>()).Concat(new[] { nyAnsat }).ToArray();
                

        }

        public string retunerLocation()
        {
            return lokation;
        }

        public void redigerLocation(string nyLokation)
        {
            lokation = nyLokation;
        }

        public bool retunerAdmin()
        {
            return admin;
        }
    }
}
