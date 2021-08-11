using System;
using System.Collections.Generic;
using System.Text;

namespace garnClass
{
    public class Ordre
    {
        private Vare[] bestillinger;
        private int ordreId;
        private string bestillingsDato;
        private string leveringsDato;
        private int totalPris;

        public Ordre(Vare[] bestillinger, int ordreId, string bestillingsDato, string leveringsDato, int totalPris)
        {
            this.bestillinger = bestillinger;
            this.ordreId = ordreId;
            this.bestillingsDato = bestillingsDato;
            this.leveringsDato = leveringsDato;
            this.totalPris = totalPris;
        }

        public int retunerOrdreId()
        {
            return ordreId;
        }

        public Vare[] retunerBestillinger()
        {
            return bestillinger;
        }

        public string retunerBestillingsDato()
        {
            return bestillingsDato;
        }

        public string retunerLeveringsDato()
        {
            return leveringsDato;
        }

        public int retunerTotalPris()
        {
            return totalPris;
        }

        public void redigerLevering(string Levering)
        {
            leveringsDato = Levering;
        }

        public void redigerPris(int pris)
        {
            totalPris = pris;
        }

        public void redigerBestiling(Vare[] Bestilling)
        {
            bestillinger = Bestilling;
        }

    }
}
