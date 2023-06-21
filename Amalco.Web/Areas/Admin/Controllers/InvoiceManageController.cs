using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amalco.Data.Repositories.Interfaces;
using Amalco.Data.ViewModels;
using Amalco.Web.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Amalco.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class InvoiceManageController : BaseController
    {
        IHostingEnvironment _appEnvironment;
        public InvoiceManageController(IUnitofWork uow, IHostingEnvironment appEnvironment) : base(uow)
        {
            _appEnvironment = appEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var list = await Uow.ServiceRepository.GetInvoices();
            return View(list);
        }

        public async Task<IActionResult> AddEdit()
        {
            InvoiceModel invoiceModel = new InvoiceModel();
            return View(invoiceModel);
        }
    }
}
