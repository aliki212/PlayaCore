using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayaCore.Models.Repositories
{
    interface IPositionRepository
    {
        IEnumerable<Position> AllPositions { get; }

        Position GetPositionByid(int positionId);
    }
}
