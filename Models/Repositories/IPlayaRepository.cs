using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayaCore.Models.Repositories
{
    interface IPlayaRepository
    {
        IEnumerable<Playa> AllCandidates { get; }

        Playa GetPlayaById(int playaId);

        public IEnumerable<Playa> NotInjuredPlayas();
    }
}
