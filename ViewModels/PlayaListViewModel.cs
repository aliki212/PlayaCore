using PlayaCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayaCore.ViewModels
{
    public class PlayaListViewModel
    {
        public IEnumerable<Playa> Playas { get; set; }

        public string Header { get; set; }

    }
}
