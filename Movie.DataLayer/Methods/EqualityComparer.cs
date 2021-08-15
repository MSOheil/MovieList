using Movie.ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DataLayer.Methods
{
    public class EqualityComparer : IEqualityComparer<RateMovieViewModel>
    {
        public bool Equals(RateMovieViewModel x, RateMovieViewModel y)
        {
            return x.MovieId == y.MovieId &&
           x.DirectorName == y.DirectorName &&
           x.MovieNamee == y.MovieNamee &&
           x.ProductionDate == y.ProductionDate;
        }

        public int GetHashCode(RateMovieViewModel obj)
        {
            return obj.MovieId.GetHashCode() ^
            obj.MovieNamee.GetHashCode() ^
            obj.MovieId.GetHashCode() ^
            obj.ProductionDate.GetHashCode();
        }
    }
}
