using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.ViewModel.ViewModel
{
    public class RateMovieViewModel
    {
        public int MovieId { get; set; }
        public string MovieNamee { get; set; }
        public double MovieAverageRateByRateUsers { get; set; } = 0;
        public int ProductionDate { get; set; }
        public string DirectorName { get; set; }
        public string GenresNamee { get; set; }


    }
}
