using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Client
    {
        public string Adresse { get; set; }
        [Key]
        public string CIN { get; set; }
        public string Email { get; set; }
        public string Nom { get; set; }
        [StringLength(8)]
        public int NumeroTelephone { get; set; }
        public string Prenom { get; set; }
        public virtual IList<JouetEducatif> JouetEducatif { get; set; }
        public virtual IList<Commande> Commande { get; set; }
    }
}
