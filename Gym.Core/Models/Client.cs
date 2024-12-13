using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Timing { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime DateJoin { get; set; }
        public string Status { get; set; }
        public int? CoachId { get; set; }
        public Coach Coach { get; set; }
        public int? MembershipId { get; set; }
        public Membership Membership { get; set; }
    }
}
