using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.ViewModel.Model
{
    public class MovieDTO
    {
        public int MovieId { get; set; }
        public string MovieNamee { get; set; }
        public IEnumerable<double> MovieAverageRateByRateUsers { get; set; }
        public int ProductionDate { get; set; }
        public string DirectorName { get; set; }
        public string GenresNamee { get; set; }


    }
}
