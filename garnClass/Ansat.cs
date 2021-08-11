using System;
using System.Collections.Generic;
using System.Text;

namespace garnClass
{
    public class Ansat
    {
        private string navn;
        private string fødselsdag;
        private int tlf;
        private string email;
        private string jobTitel;
        private string adresse;
        private int løn;
        private int postNr;
        private bool admin;
        private int arbejd;

        public Ansat(string navn, string fødselsdag, int tlf, string email, string jobTitel, string adresse, int løn, int postNr, bool admin , int arbejd)
        {
            this.navn = navn;
            this.fødselsdag = fødselsdag;
            this.tlf = tlf;
            this.email = email;
            this.jobTitel = jobTitel;
            this.adresse = adresse;
            this.løn = løn;
            this.postNr = postNr;
            this.admin = admin;
            this.arbejd = arbejd;
        }

        public void arbejde()
        {
            arbejd += 8;
        }

        public void redigerTlf(int nyTlf)
        {
            tlf = nyTlf;
        }

        public void redigerEmail(string nyMail)
        {
            email = nyMail;
        }

        public void redigerJobtitel(string nyJobTitel)
        {
            jobTitel = nyJobTitel;
        }

        public void redigerAdresse(string nyAddresse)
        {
            adresse = nyAddresse;
        }

        public void redigerLøn(int nyLøn)
        {
            løn = nyLøn;
        }

        public void redigerPostNr(int nyPost)
        {
            postNr = nyPost;
        }

        public void redigerAdminStatus(bool isAdmin)
        {
            admin = isAdmin;
        }

        public void redigerFødselsdag(string fød)
        {
            fødselsdag = fød;
        }

        public string retunerNavn()
        {
            return navn;
        }

        public string retunerFødselsdato()
        {
            return fødselsdag;
        }

        public int retunerTfl()
        {
            return tlf;
        }

        public string retunerEmail()
        {
            return email;
        }

        public string retunerJobtitle()
        {
            return jobTitel;
        }

        public string retunerAdresse()
        {
            return adresse;
        }

        public int retunerLøn()
        {
            return løn;
        }

        public int retunerPostNr()
        {
            return postNr;
        }

        public bool retunerAdmin()
        {
            return admin;
        }

    }
}
