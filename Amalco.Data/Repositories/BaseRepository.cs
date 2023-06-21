using System;
using System.Collections.Generic;
using System.Text;
using Amalco.Data.Repositories.Interfaces;
namespace Amalco.Data.Repositories
{
    public class BaseRepository:IBaseRepository
    {
        protected Context _context;

        public BaseRepository(Context context)
        {
            _context = context;
        }
    }
}
