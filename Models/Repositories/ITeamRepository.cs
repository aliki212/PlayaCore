using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayaCore.Models.Repositories
{
    interface ITeamRepository
    {
        IEnumerable<Team> AllTeams { get; }

        Team GetTeamById(int teamId);
    }
}
