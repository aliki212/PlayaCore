using Microsoft.EntityFrameworkCore;
using PlayaCore.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayaCore.Models
{
    public class PlayaRepository : IPlayaRepository
    {
        private readonly AppDbContext _context;

        public PlayaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Playa> AllCandidates => _context.Playas.Include(p =>p.Team).Include(p=>p.Position).ToList();

        public Playa GetPlayaById(int playaId)
        {
            return _context.Playas.Where(p => p.Id == playaId).FirstOrDefault();
        }

        public IEnumerable<Playa> NotInjuredPlayas()
        {
            return _context.Playas.Include(p => p.Team).Include(p => p.Position).Where(p => p.IsNotInjured);
        }
    }
}
