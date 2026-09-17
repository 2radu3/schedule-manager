using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Classes
{
    [Serializable]
    public class Disciplina : EntitateBaza, ICloneable, IComparable
    {
        public string Denumire { get; set; }

        public override string ToString() => Denumire;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Disciplina alta = obj as Disciplina;
            if (alta != null)
            {
                return this.Denumire.CompareTo(alta.Denumire);
            }
            else
            {
                throw new Exception("Obiectul nu este disciplina");
            }
        }

        public override string ObtineDescriere()
        {
            return $"Disciplina: {Denumire} (Cod: {Id})";
        }
    }


}
