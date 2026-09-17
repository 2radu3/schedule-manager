using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    [Serializable]
    public abstract class EntitateBaza
    {
        public int Id { get; set; }

        public abstract string ObtineDescriere();
    }
}
