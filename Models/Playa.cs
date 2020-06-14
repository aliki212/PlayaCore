using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayaCore.Models
{
    public class Playa
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        public bool IsNotInjured { get; set; }

        public string ImageUrl { get; set; }

        public int TeamId { get; set; }

        public Team Team { get; set; }

        public int PositionId { get; set; }

        public Position Position { get; set; }
    }
}
