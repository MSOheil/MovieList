using Microsoft.EntityFrameworkCore;
using Movie.DataLayer.Repositories;
using Movie.DataLayer.Servicess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DataLayer.Data
{
    public class UnitOfWork : IDisposable
    {

        MovieContext_DBEntities8 db = new MovieContext_DBEntities8();
        private IMovieListRepository _movieList;
        public IMovieListRepository MovieList
        {
            get
            {
                if (_movieList == null)
                {
                    _movieList = new MovieRepository(db);
                }
                return _movieList;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
