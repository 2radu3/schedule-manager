using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    [Serializable]
    public class Sala : EntitateBaza
    {
        public string Denumire { get; set; }
        public int Capacitate { get; set; }
        public string Tip { get; set; }

        public override string ToString() => Denumire;

        public static Sala operator +(Sala s, int scauneSuplimentare)
        {
            Sala salaNoua = new Sala
            {
                Id = s.Id,
                Denumire = s.Denumire,
                Tip = s.Tip,
                Capacitate = s.Capacitate + scauneSuplimentare
            };
            return salaNoua;
        }

        public static Sala operator ++(Sala s)
        {
            s.Capacitate += 1;
            return s;
        }

        public static bool operator <(Sala s1, Sala s2)
        {
            return s1.Capacitate < s2.Capacitate;
        }

        public static bool operator >(Sala s1, Sala s2)
        {
            return s1.Capacitate > s2.Capacitate;
        }

        public static explicit operator int(Sala s)
        {
            return s.Capacitate;
        }

        public override string ObtineDescriere()
        {
            return $"Sala: {Denumire}, Capacitate: {Capacitate} locuri";
        }
    }
}
