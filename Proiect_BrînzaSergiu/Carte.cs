using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_BrînzaSergiu
{
    [Serializable]
    public class Carte:ICategorie, ICloneable, IComparable
    {
        private string denumire;
        private string autor;
        private string isbn;
        private string editura;
        private int an;
        private string categorie;
        private bool academ;

        public Carte()
        {
            autor = "Unknown";
            denumire = "Unknown";
            isbn = "Undifined";
            editura = "Unknown";
            an = 1500;
            categorie = "Undifined";
            academ = false;
        }

        public Carte(string d, string aut, string i, string e, int a, string c, bool w)
        {
            denumire = d;
            autor = aut;
            isbn = i;
            editura = e;
            an = a;
            categorie = c;
            academ = w;
        }

        public bool Academ
        {
            get { return this.academ; }
            set { this.academ = value; }
        }
        public string Denumire
        {
            get { return this.denumire; }
            set { this.denumire = value; }
        }
        public string Autor
        {
            get { return this.autor; }
            set { this.autor = value; }
        }
        public string Isbn
        {
            get { return this.isbn; }
            set { this.isbn = value; }
        }

        public string Editura
        {
            get { return this.editura; }
            set { this.editura = value; }
        }

        public int An
        {
            get { return this.an; }
            set { this.an = value; }
        }

        public string Categorie
        {
            get { return this.categorie; }
            set { this.categorie = value; }
        }

        public override string ToString()
        {
            return "Cartea " + denumire +" cu autorul: "+autor+ " de la editura " + editura + " editată în anul " + an + " din categoria " + categorie + " are ISBN-ul " + isbn;
        }

        public object Clone()
        {
            Carte clona = (Carte)this.MemberwiseClone();
            return clona;
        }

        public string afiseazaCategoria()
        {
            return this.categorie;
        }

        public int CompareTo(object obj)
        {
            Carte c = (Carte)obj;
            if (this.an < c.an)
                return -1;
            else
                if (this.an > c.an)
                return 1;
            else
                return string.Compare(this.denumire, c.denumire);
        }
    }
}
