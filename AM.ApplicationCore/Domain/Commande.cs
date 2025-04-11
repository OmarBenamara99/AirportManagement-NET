using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Commande
    {
        public DateTime DateCommande { get; set; }
        [Range(0, 2000)]
        public double MontantTotal { get; set; }
        public virtual Client Client { get; set; }
        public virtual JouetEducatif JouetEducatif { get; set; }
        public int ClientFK { get; set; }
        public string JouetFK { get; set; }
    }
}
