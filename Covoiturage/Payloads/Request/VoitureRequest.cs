using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covoiturage.Payloads.Request
{
    public class VoitureRequest
    {
        public long id { get; set; }
        public string type { get; set; }
        public string marque { get; set; }
        public List<OffreRequest> offre { get; set; }
    }
}
