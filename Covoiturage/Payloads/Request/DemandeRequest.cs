using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covoiturage.Payloads.Request
{
    public class DemandeRequest
    {
        public long id { get; set; }
        public DateTime dateDemande { get; set; }
        public string etat { get; set; }
        public RegisterRequest demandeur { get; set; }
        public OffreRequest offre { get; set; }
    }
}
