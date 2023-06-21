using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amalco.Data.Repositories.Interfaces;
using Amalco.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Amalco.Data.ViewModels.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;
namespace Amalco.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ServiceManageController : BaseController
    {
        IHostingEnvironment _appEnvironment;
        public ServiceManageController(IUnitofWork uow, IHostingEnvironment appEnvironment) :base(uow)
        {
            _appEnvironment = appEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var list = await Uow.ServiceRepository.AdminServiceList();
            return View(list);

        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(int?id)
        {
            ServiceAddEdit model = id.HasValue? await Uow.ServiceRepository.GetforEdit(id.Value): new ServiceAddEdit();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(ServiceAddEdit model,IFormFile MainImageFile)
        {
            if(MainImageFile!=null)
            {
                string filename = Guid.NewGuid().ToString()+Path.GetExtension(MainImageFile.FileName);
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + $"/Images/Services/{filename}", FileMode.Create))
                {
                    await MainImageFile.CopyToAsync(fileStream);
                }
                model.MainImage = filename;

            }
            if(model.ResponsibilityStrings!=null)
            {
                model.Responsibility = String.Join('@', model.ResponsibilityStrings.Where(p=>!String.IsNullOrEmpty(p)));
            }
            if(model.Id==0)
            {
                await Uow.ServiceRepository.Add(model);
            }
            else
            {
                await Uow.ServiceRepository.Update(model);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
           var delete= await Uow.ServiceRepository.GetforEdit(id);
           return PartialView("_Delete", delete);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteService(int id)
        {
            await Uow.ServiceRepository.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile image)
        {
            if (image != null)
            {
                string filename = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + $"/Images/uploads/{filename}", FileMode.Create))
                {
                    await image.CopyToAsync(fileStream);
                }
                return Json(new { success = true,message=filename });

            }
            return Json(new { success = false });
        }
    }
}