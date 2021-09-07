using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayHistory.Models
{
    public class PayRequest
    {
        public string RqUid { get; set; }
        public string RqTime { get; set; }
        public string RRN { get; set; }
        public string SRN { get; set; }
    }
}
