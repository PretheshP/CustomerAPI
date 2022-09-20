using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMicroservice.Models
{
    public class customerCreationStatus
    {
        public string message { get; set; }
        public int customerId { get; set; }
        public int currentAccountId { get; set; }
        public int savingsAccountId { get; set; }
    }
}
