using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayaCore.Models
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Playa> TeamPlayas { get; set; }
    }
}
