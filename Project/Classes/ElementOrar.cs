using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    [Serializable]
    public class ElementOrar : EntitateBaza, ICloneable, IComparable
    {


        public Profesor ProfesorSarcina { get; set; }
        public Sala SalaSarcina { get; set; }
        public Disciplina DisciplinaSarcina { get; set; }

        public string Ziua { get; set; }
        public string IntervalOrar { get; set; }
        public string TipActivitate { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            ElementOrar altul = obj as ElementOrar;
            if (altul != null)
            {
                return this.Id.CompareTo(altul.Id);
            }
            else
            {
                throw new Exception("Obiectul nu este element orar");
            }
        }

        public override string ObtineDescriere()
        {
            return $"Programare {Ziua} la {IntervalOrar}: {DisciplinaSarcina.Denumire} cu {ProfesorSarcina.Nume} in sala {SalaSarcina.Denumire}";
        }
    }
}
