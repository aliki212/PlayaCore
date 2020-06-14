using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayaCore.Models.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly AppDbContext _context;

        public TeamRepository(AppDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Team> AllTeams => _context.Teams; // no need for .ToList() unless we need it to display - better for memory

        public Team GetTeamById(int teamId)
        {
            return _context.Teams.Where(t => t.Id == teamId).FirstOrDefault();
        }
    }
}
