using System;
using System.Linq;

namespace garnClass
{
    public class Virksomhed
    {
        private Fabrikker[] fabrikker;
        private Afdeling[] afdelinger;
        private Kunder[] kunder;

        public Virksomhed(Fabrikker[] fabrikker, Afdeling[] afdelinger, Kunder[] kunder)
        {
            this.fabrikker = fabrikker;
            this.afdelinger = afdelinger;
            this.kunder = kunder;

        }
        
        public void fjernFabrk(Fabrikker fabrik)
        {
            fabrikker = fabrikker.Where(val => val != fabrik).ToArray();
        }

        public void tilføjFabrik(Fabrikker fabrik)
        {
            fabrikker = (fabrikker ?? Enumerable.Empty<Fabrikker>()).Concat(new[] { fabrik }).ToArray();
        }

        public void fjernKunde(Kunder kunde)
        {
            kunder = kunder.Where(val => val != kunde).ToArray();
        }

        public void tilføjKunde(Kunder kunde)
        {
            kunder = (kunder ?? Enumerable.Empty<Kunder>()).Concat(new[] { kunde }).ToArray();
        }

        public void lukAfdeling(Afdeling afdeling)
        {
            afdelinger = afdelinger.Where(val => val != afdeling).ToArray();
        }

        public void åbenAfdeling(Afdeling afdeling)
        {
            afdelinger = (afdelinger ?? Enumerable.Empty<Afdeling>()).Concat(new[] { afdeling }).ToArray();
        }
    }

    
}
