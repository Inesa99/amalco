using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amalco.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Amalco.Web.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IUnitofWork Uow;
        public BaseController(IUnitofWork uow)
        {
            Uow = uow;
        }

         
    }
}