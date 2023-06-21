using System;
using System.Collections.Generic;
using System.Text;
using Amalco.Data.Repositories.Interfaces;
namespace Amalco.Data.Repositories
{
    public class UnitofWork : IUnitofWork
    {
        private Context Context;
        public UnitofWork(Context _context)
        {
            Context = _context;
        }

        

        private IPageRepository _pageRepository;
        private IServiceRepository _serviceRepository;
       

        public IPageRepository PageRepository => _pageRepository ?? new PageRepository(Context);
        public IServiceRepository ServiceRepository => _serviceRepository ?? new ServiceRepository(Context);
      

        bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
