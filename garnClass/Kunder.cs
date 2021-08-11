using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace garnClass
{
    public class Kunder
    {
        private string type;
        private int postNummer;
        private string adresse;
        private Ordre[] ordre;
        private string navn;

        public Kunder(string type, int postNummer, string adresse, Ordre[] ordre, string navn)
        {
            this.type = type;
            this.postNummer = postNummer;
            this.adresse = adresse;
            this.ordre = ordre;
            this.navn = navn;
        }

        public void besilling(Vare[] vare)
        {
            int pris = 0;
            int pos = 0;
            while(pos < vare.Length)
            {
                pris = pris + vare[pos].retunerPris();
                pos += 1;
            }
            DateTime today = DateTime.Today;
            Ordre nyodre = new Ordre(vare, ordre.Length + 1, today.ToString(), today.AddDays(3).ToString(), pris);

            ordre = (ordre ?? Enumerable.Empty<Ordre>()).Concat(new[] { nyodre }).ToArray();
        }

        public void afbestilVare(int oId, Vare vare)
        {
            int pos = 0;
            int vpos = 0;
            while(pos < ordre.Length)
            {
                if(oId == ordre[pos].retunerOrdreId())
                {
                    Vare[] vareSamling = ordre[pos].retunerBestillinger();

                    while(vpos < vareSamling.Length)
                    {
                        if(vareSamling[vpos] == vare)
                        {
                            var tempVare = new List<Vare>(vareSamling);
                            tempVare.RemoveAt(vpos);
                            vareSamling = tempVare.ToArray();
                            ordre[pos].redigerBestiling(vareSamling);
                            ordre[pos].redigerPris(vare.retunerPris() - ordre[pos].retunerTotalPris());
                        }
                        else
                        {
                            vpos += 1;
                        }
                    }

                    

                    
                }
                else
                {
                    pos += 1;
                }
            }
        }

        public string retunerType()
        {
            return type;
        }

        public void redigerPostnummer(int nytPostnummer)
        {
            postNummer = nytPostnummer;
        }

        public int retunerPostnummer()
        {
            return postNummer;
        }

        public void redigerAdresse(string nyAddresse)
        {
            adresse = nyAddresse;
        }

        public string returnerAdresse()
        {
            return adresse;
        }

        public string returnerNavn()
        {
            return navn;
        }
    }
}
