using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Amalco.Data.Repositories.Interfaces;
using Amalco.Data.ViewModels.Service;
using Amalco.Web.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace Amalco.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ReviewManageController : BaseController
    {
        IHostingEnvironment _appEnvironment;
        public ReviewManageController(IUnitofWork uow, IHostingEnvironment appEnvironment):base(uow)
        {
            _appEnvironment = appEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var model = await Uow.ServiceRepository.AdminReviewList();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(int? id)
        {
            var model = id.HasValue? await Uow.ServiceRepository.ReviewEdit(id.Value): new ReviewVM();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(ReviewVM model,IFormFile MainImageFile)
        {
            if (MainImageFile != null)
            {
                string filename = Guid.NewGuid().ToString() + Path.GetExtension(MainImageFile.FileName);
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + $"/Images/Reviews/{filename}", FileMode.Create))
                {
                    await MainImageFile.CopyToAsync(fileStream);
                }
                model.Image = filename;

            }

            if(model.Id==0)
            {
                await Uow.ServiceRepository.AddReview(model);
            }
            else
            {
                await Uow.ServiceRepository.UpdateReview(model);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await Uow.ServiceRepository.ReviewEdit(id);
            return PartialView("_Delete", delete);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteReview(int id)
        {
            await Uow.ServiceRepository.DeleteReview(id);
            return RedirectToAction("Index");
        }
    }
}