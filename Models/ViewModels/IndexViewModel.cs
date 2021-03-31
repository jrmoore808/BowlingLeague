using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//ViewModel for the Index page. Sets up Bowlers with Teams and Paging info
namespace BowlingLeague.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Bowler> Bowlers { get; set; }
        public PageNumInfo PageNumInfo { get; set; }
        public string TeamCategory { get; set; }

    }
}
