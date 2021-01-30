using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covoiturage.Payloads.Request
{
    public class RechercheRequest
    {
        public string prix { get; set; }
        public string lieuDepart { get; set; }
        public string lieuArrivee { get; set; }
        public DateTime dateDepart { get; set; }
        public string typeVoiture { get; set; }
        public string escales { get; set; }
    }
}
