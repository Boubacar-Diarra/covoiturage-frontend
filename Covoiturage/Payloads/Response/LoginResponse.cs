using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covoiturage.Payloads.Response
{
    public class LoginResponse
    {
        public long id { get; set; }
        public string token { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string nom { get; set; }
        public string description { get; set; }
    }
}
