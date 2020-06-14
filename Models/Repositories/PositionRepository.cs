using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayaCore.Models.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private readonly AppDbContext _context;

        public PositionRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Position> AllPositions => _context.Positions;

        public Position GetPositionByid(int positionId)
        {
            return _context.Positions.Where(p => p.Id == positionId).FirstOrDefault();
        }
    }
}
