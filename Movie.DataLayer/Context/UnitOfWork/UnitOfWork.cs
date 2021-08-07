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

        MovieContext_DBEntities1 db = new MovieContext_DBEntities1();
        private IMovieList _movieList;
        public IMovieList MovieList
        {
            get
            {
                if (_movieList == null)
                {
                    _movieList = new MovieList(db);
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
