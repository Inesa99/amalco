using System;
using System.Collections.Generic;
using System.Text;
using Amalco.Data.Repositories.Interfaces;
namespace Amalco.Data.Repositories.Interfaces
{
    public interface IUnitofWork : IDisposable
    {
        IPageRepository PageRepository { get; }
        IServiceRepository ServiceRepository { get; }
       
    }
}
