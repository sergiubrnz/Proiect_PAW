using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_BrînzaSergiu
{
    [Serializable]
    public class CititorAcadem : Cititor, ICloneable, IComparable
    {
        private string CNP;
        private string universitate;
        private string titlu;

        public CititorAcadem():base()
        {
            universitate = "";
            titlu = "";
            CNP = "";
        }

        public CititorAcadem(int c, string a, string n, string t, string e, DateTime d, string p, string cnp, string u, string titlu) : base(c, a, n, t, e, d, p)
        {
            this.CNP = cnp;
            this.universitate = u;
            this.titlu = titlu;
            this.tip = "Academic";
            this.cartiImprumutate = new List<Carte>();
        }

        public string CodNumericPersonal
        {
            get { return this.CNP; }
            set
            {
                if (value != null)
                    this.CNP = value;
            }
        }

        public string Universitate
        {
            set { if (value != null) universitate = value; }
            get { return this.universitate; }
        }

        public string Titlu
        {
            set { if (value != null) titlu = value; }
            get { return this.titlu; }
        }

        public override string ToString()
        {
            return base.ToString() + "CNP: " + CNP + Environment.NewLine
                                   + "Universitatea: " + universitate + Environment.NewLine
                                   + "Titlul: " + titlu + Environment.NewLine;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            CititorAcadem c_acad = (CititorAcadem)obj;
            return string.Compare(this.CNP, c_acad.CNP);
        }
    }
}
