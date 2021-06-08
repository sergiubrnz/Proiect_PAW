using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_BrînzaSergiu
{
    [Serializable]
    public class Cititor:ICloneable
    {
        protected int cod_cititor;
        protected string nume;
        protected string adresa;
        protected string nrTelefon;
        protected string email;
        protected DateTime dataNastere;
        protected string parola;
        protected List<Carte> cartiImprumutate;
        public string tip;

        public Cititor()
        {
            cod_cititor = 0;
            nume = "";
            adresa = "";
            nrTelefon = "";
            email = "";
            parola = "";
            dataNastere = DateTime.Now;
            cartiImprumutate = new List<Carte>();
            tip = "Adult";
        }

        public Cititor(int c, string a, string n, string t, string e, DateTime d, string p)
        {
            this.cod_cititor = c;
            this.nume = n;
            this.adresa = a;
            this.nrTelefon = t;
            this.email = e;
            this.dataNastere = d;
            this.parola = p;
            this.cartiImprumutate = new List<Carte>();
        }

        public int CodCititor
        {
            get { return this.cod_cititor; }
            set { if (value > 0 ) cod_cititor = value; }
        }

        public string Adresa
        {
            set { if (value != null) adresa = value; }
            get { return this.adresa; }
        }

        public string Nume
        {
            set { if (value != null) nume = value; }
            get { return this.nume; }
        }

        public string NrTelefon
        {
            set { if (value != null) nrTelefon = value; }
            get { return this.nrTelefon; }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                try
                {
                    var mail = new System.Net.Mail.MailAddress(value);
                    if (mail.Address == value)
                        email = value;
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Adresa de mail nu corespunde formatului.\nAsigura-te ca ai introdus datele corect.");
                }
            }
        }

        public string Parola
        {
            get { return this.parola; }
            set { if (value != null) parola = value; }
        }

        public string Tip
        {
            get { return this.tip; }
            set { if (value != null) tip = value; }
        }

        public DateTime DataNastere
        {
            get;
            set;
        }

        public List<Carte> CartiImprumutate
        {
            get { return cartiImprumutate; }
            set { if (value != null) cartiImprumutate = value; }
        }

        public object Clone()
        {
            Cititor clona = (Cititor)this.MemberwiseClone();
            List<Carte> listaNoua = new List<Carte>();
            foreach (Carte c in CartiImprumutate)
                listaNoua.Add((Carte)c.Clone());
            clona.CartiImprumutate = listaNoua;
            return clona;
        }

        public override string ToString()
        {

            string rez = "Nume utilizator: " + Nume + Environment.NewLine +
            "Codul utilizatorului: " + CodCititor + Environment.NewLine +
            "Născut la dat de " + DataNastere + Environment.NewLine +
            "Email: " + Email + Environment.NewLine +
            "Nr. telefon: " + NrTelefon + Environment.NewLine +
            "Adresa:" + Adresa + Environment.NewLine+
            "Tip: "+tip+Environment.NewLine;
            if (CartiImprumutate.Count == 0)
            {
                rez += "Nu are cărți împrumutate"+Environment.NewLine;
            }
            else
            {
                rez+= " Și are următoarele cărți împrumutate " + Environment.NewLine;
                foreach (Carte c in CartiImprumutate)
                    rez += c.ToString() + Environment.NewLine;
            }
            return rez;
        }

        public void modificaParola(string parolaN)
        {
            if (parolaN != this.parola)
                this.parola = parolaN;
        }

        public Carte this[int index]
        {
            get
            {
                if (cartiImprumutate != null && index >= 0 && index < CartiImprumutate.Count)
                    return CartiImprumutate[index];
                else
                    return null;
            }
        }

        public static Cititor operator +(Cititor cit, Carte carte)
        {
            cit.CartiImprumutate.Add(carte);
            return cit;
        }
    }
}
