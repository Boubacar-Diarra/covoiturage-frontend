using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Covoiturage.Payloads.Request
{
    public class OffreRequest
    {
        public long id { get; set; }
        public float prix { get; set; }
        public int nbrePlace { get; set; }
        public bool estConducteur { get; set; }
        [Required]
        public string lieuDepart { get; set; }
        [Required]
        public string lieuArrivee { get; set; }
        [Required]
        public DateTime dateDepart { get; set; }
        public bool alternance { get; set; }
        public RegisterRequest offreur { get; set; }

        public List<EscaleRequest> escales { get; set; }

        public VoitureRequest voiture { get; set; }
    }
}
