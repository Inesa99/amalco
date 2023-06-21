using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Amalco.Data.ViewModels.Order;
namespace Amalco.Web.Service
{
    public interface IEmailService
    {
        Task Send(OrderAddViewModel model);
        Task Send(string body, string subject,string to = "amalcoru@gmail.com", Stream file = null, string filename = null);
    }
}
