using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class JouetEducatifMoteur : JouetEducatif
    {
        public Materiaux Materiaux { get; set; }
        public int NiveauDeveloppement { get; set; }
    }
}
