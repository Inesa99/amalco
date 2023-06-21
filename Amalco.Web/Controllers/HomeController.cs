using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amalco.Web.Models;
using Amalco.Data.Repositories.Interfaces;
using System.Threading.Tasks;
namespace Amalco.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IUnitofWork uow) : base(uow)
        {

        }
        public async Task<IActionResult> Index()
        {
            
            ViewBag.services = await Uow.ServiceRepository.AdminServiceList();
            return View();
        }






        [Route("sitemap.xml")]
        public async Task<IActionResult> SiteMap()
        {
            var model = await Uow.PageRepository.GetUrls();
            return PartialView(model);
        }


    }
}
