using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    [Serializable]
    public class Profesor : EntitateBaza
    {
        
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string TitluAcademic { get; set; }
        public string Departamentul { get; set; }

        public override string ToString() => $"{TitluAcademic} {Nume} {Prenume}";

        private int[] orePeZile = new int[7];

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < orePeZile.Length)
                {
                    return orePeZile[index];
                }
                throw new IndexOutOfRangeException("Ziua selectata este invalida!");
            }
            set
            {
                if (index >= 0 && index < orePeZile.Length)
                {
                    orePeZile[index] = value;
                }
            }
        }

        public object Clone() => this.MemberwiseClone();

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Profesor altul = obj as Profesor;
            return string.Compare(this.Nume, altul?.Nume);
        }

        public override string ObtineDescriere()
        {
            return $"Profesor: {TitluAcademic} {Nume} {Prenume} (ID: {Id})";
        }
    }
}
