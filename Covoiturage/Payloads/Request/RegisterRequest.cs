using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covoiturage.Payloads.Request
{
    public class RegisterRequest
    {
        public long id { get; set; }
        public string username { get; set; }
        
        public string email { get; set; }
        public string telephone { get; set; }
        public string password { get; set; }
        public string nom { get; set; }
        public string description { get; set; }
        public List<OffreRequest> offres { get; set; }

    }
}
