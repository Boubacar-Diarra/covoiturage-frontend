using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covoiturage.Payloads.Request
{
    public class EscaleRequest
    {
        public long id { get; set; }
        public String lieu { get; set; }
        public String motif { get; set; }
        public OffreRequest offre { get; set; }
    }
}
