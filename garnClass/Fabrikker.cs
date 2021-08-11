using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace garnClass
{
    public class Fabrikker
    {
        private Afdeling[] afdelinger;
        private int produktionskapacitet;
        private Vare[] vareLager;
        private Materialer[] materialeLager;
        private string virksomhedsAddresse;

        public Fabrikker(Afdeling[] afdelinger, int produktionskapacitet, Vare[] vareLager, Materialer[] materialeLager, string virksomhedsAddresse)
        {
            this.afdelinger = afdelinger;
            this.produktionskapacitet = produktionskapacitet;
            this.vareLager = vareLager;
            this.materialeLager = materialeLager;
            this.virksomhedsAddresse = virksomhedsAddresse;
        }

        public int retunerProduktionskapacitet()
        {
            return produktionskapacitet;
        }

        public void Producer(int antal)
        {
            produktionskapacitet = antal;
        }

        public Vare[] retunerVarelager(Vare[] vare)
        {
            return vare;
        }

        public void redigerVarelager(int antal, string vare)
        {
            int pos = 0;
            int count = 0;
            int more = 0;
            int less = 0;

            while (pos < vareLager.Length)
            {
                if (vareLager[pos].retunerNavn() == vare)
                {
                    count += 1;
                    pos += 1;
                }
                else
                {
                    pos += 1;
                }
            }

            pos = 0;

            if (antal > count)
            {
                less = antal - count;

                while (less != 0)
                {
                    while (pos < vareLager.Length)
                    {
                        if (vareLager[pos].retunerNavn() == vare)
                        {
                            var tempLager = new List<Vare>(vareLager);
                            tempLager.RemoveAt(pos);
                            vareLager = tempLager.ToArray();
                            less -= 1;
                            pos = 0;
                        }
                        else
                        {
                            pos += 1;
                        }
                    }
                }
            }
            else if (antal < count)
            {
                more = count - antal;
                bool done = false;
                pos = 0;





                while (done == false && pos < vareLager.Length)
                {
                    if (vareLager[pos].retunerNavn() == vare)
                    {
                        while (more != 0)
                        {

                            vareLager = (vareLager ?? Enumerable.Empty<Vare>()).Concat(new[] { vareLager[pos] }).ToArray();
                            more -= 1;
                        }
                        done = true;
                    }
                    else
                    {
                        pos += 1;
                    }

                }
            }
        }

        public Afdeling[] retunerAfdelinger()
        {
            return afdelinger;
        }

        public void fjernAfdelinger(string afdeling)
        {
            int pos = 0;
            while(pos < afdelinger.Length)
            {
                if(afdelinger[pos].retunerNavn() == afdeling)
                {
                    afdelinger = afdelinger.Where(val => val != afdelinger[pos]).ToArray();
                }
            }
            
        }

        public void tilføjAfdeling(string afdeling)
        {

            int pos = 0;
            while (pos < afdelinger.Length)
            {
                if (afdelinger[pos].retunerNavn() == afdeling)
                {
                    afdelinger = (afdelinger ?? Enumerable.Empty<Afdeling>()).Concat(new[] { afdelinger[pos] }).ToArray();
                }
            }
            
        }

        public void købMaterialer(int antal, string materialeNavn)
        {
            int count = antal;
            bool done = false;
            int pos = 0;

           

            while (done == false && pos < materialeLager.Length)
            {
                if (materialeLager[pos].retunerName() == materialeNavn)
                {
                    while (count != 0)
                    {

                        materialeLager = (materialeLager ?? Enumerable.Empty<Materialer>()).Concat(new[] { materialeLager[pos] }).ToArray();
                        count -= 1;
                    }
                    done = true;
                }
                else
                {
                    pos += 1;
                }

            }

        }

        public Materialer[] retunerMaterialeLager()
        {
            return materialeLager;
        }

        public void redigerMaterialeLager(int antal, string materialeNavn)
        {
            int pos = 0;
            int count = 0;
            int more = 0;
            int less = 0;

            while (pos < materialeLager.Length)
            {
                if (materialeLager[pos].retunerName() == materialeNavn)
                {
                    count += 1;
                    pos += 1;
                }
                else
                {
                    pos += 1;
                }
            }

            pos = 0;

            if (antal > count)
            {
                less = antal - count;

                while (less != 0)
                {
                    while (pos < materialeLager.Length)
                    {
                        if (materialeLager[pos].retunerName() == materialeNavn)
                        {
                            var tempLager = new List<Materialer>(materialeLager);
                            tempLager.RemoveAt(pos);
                            materialeLager = tempLager.ToArray();
                            less -= 1;
                            pos = 0;
                        }
                        else
                        {
                            pos += 1;
                        }
                    }
                }
            }
            else if (antal < count)
            {
                more = count - antal;
                bool done = false;
                pos = 0;

                

                

                while (done == false && pos < materialeLager.Length)
                {
                    if (materialeLager[pos].retunerName() == materialeNavn)
                    {
                        while (more != 0)
                        {

                            materialeLager = (materialeLager ?? Enumerable.Empty<Materialer>()).Concat(new[] { materialeLager[pos] }).ToArray();
                            more -= 1;
                        }
                        done = true;
                    }else
                    {
                        pos += 1;
                    }

                }
            }
        }

        public string returnerVirksomhedsaddresse()
        {
            return virksomhedsAddresse;
        }

    }
}
