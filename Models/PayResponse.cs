using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayHistory.Models
{
    public class PayResponse
    {
        public string RqUid { get; set; }
        public string RsTime { get; set; }
        public string RRN { get; set; }
        public string SRN { get; set; }
        public int Amount { get; set; }
    }
}
