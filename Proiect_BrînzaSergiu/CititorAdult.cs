using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_BrînzaSergiu
{
    [Serializable]
    public class CititorAdult : Cititor, ICloneable, IComparable
    {
        private string CNP;

        public CititorAdult():base()
        {
            this.CNP = "Neinitializat";
        }

        public CititorAdult(int c, string a, string n, string t, string e, DateTime d, string p,  string cnp):base(c,a,n,t,e,d,p)
        {
            this.CNP = cnp;
            this.tip = "Adult";
            this.CartiImprumutate = new List<Carte>();
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

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            CititorAdult ca = (CititorAdult)obj;
            return string.Compare(this.CNP, ca.CNP);
        }

        public override string ToString()
        {
            return base.ToString()+ " si CNP-ul " + CNP+Environment.NewLine;
        }
    }
}
