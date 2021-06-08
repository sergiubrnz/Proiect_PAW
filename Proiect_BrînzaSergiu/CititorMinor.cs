using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_BrînzaSergiu
{
    [Serializable]
    public class CititorMinor : Cititor, ICloneable, IComparable
    {
        private CititorAdult parinte;

        public CititorMinor() : base()
        {
            parinte = new CititorAdult();
        }

        public CititorMinor(int c, string a, string n, string t, string e, DateTime d, string p, CititorAdult adult) : base(c, a, n, t, e, d, p)
        {
            this.parinte = adult;
            this.tip = "Minor";
            this.cartiImprumutate = new List<Carte>();
        }

        public CititorAdult Parinte
        {
            get { return parinte; }
            set
            {
                if (value != null)
                    this.parinte = value;
            }

        }

        public override string ToString()
        {
            return base.ToString() + " Universitate " + parinte + Environment.NewLine;
        }

        public object Clone()
        {
            CititorMinor minor = (CititorMinor)this.MemberwiseClone();
            CititorAdult adult = new CititorAdult();
            minor.parinte = adult;
            return minor;
        }

        public int CompareTo(object obj)
        {
            CititorMinor cm = (CititorMinor)obj;
            return string.Compare(this.parinte.ToString(), cm.parinte.ToString());
        }
    }
}
