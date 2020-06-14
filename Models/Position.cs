using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayaCore.Models
{
    public class Position
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Playa> Playas { get; set; }
    }
}
