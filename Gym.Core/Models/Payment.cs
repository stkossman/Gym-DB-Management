using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public Client Member { get; set; }
        public DateTime DatePeriod { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}
