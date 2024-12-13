using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Models
{
    public class Coach
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime DateBirth { get; set; }
    }
}
