using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class JouetEducatif
    {
        [Range(0, 10)]
        public int AgeMax { get; set; }
        [Range(3, int.MaxValue)]
        public int AgeMin { get; set; }
        [Key]
        public int Code { get; set; }
        public string Description { get; set; }
        public string Libelle { get; set; }
        [Range(0, 2000)]
        public double Prix { get; set; }
        public virtual IList<Client> Clients { get; set; }
        public virtual IList<Commande> Commande { get; set; }
    }
}
