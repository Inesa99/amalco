using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amalco.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Amalco.Web.Service;
using Amalco.Data.ViewModels.Order;
using Amalco.Web.Extentions;
using Amalco.Data.Enums;
namespace Amalco.Web.Controllers
{
    public class StaticPageController : BaseController
    {
        private readonly IEmailService _emailService;
        public StaticPageController(IUnitofWork uow,IEmailService emailService):base(uow)
        {
            _emailService = emailService;
        }
        public async Task<IActionResult> About()
        {
            var model = await Uow.PageRepository.GetByIdOrUrl(url: "ob-agentstve");
            return View(model);
        }
        public IActionResult Contacts()
        {

            return View();
        }
        public IActionResult Prices()
        {
            return View();
        }
        public async Task<IActionResult> Applicants()
        {
            if (TempData["FromResponse"]!=null)
            {
                ViewBag.fromresponse = true;
               
            }
            var model = await Uow.PageRepository.GetByIdOrUrl(url: "soiskatelyam");
            ViewBag.vacancies = await Uow.ServiceRepository.GetAllVacancy(1);
            return View(model);
             
        }
        public IActionResult Article()
        {

            return View();
        }

        public async Task<IActionResult> VacancyDetail(int id)
        {
            var model = await Uow.ServiceRepository.GetVacancy(id);
            return PartialView("_VacancyDetail", model);
        }

        [HttpPost]
        
        public async Task<IActionResult> VacancyResponse(int VacancyId, bool FamilyExperience, string FullName, string Number, IFormFile CVFile)
        {
            var vacancy = await Uow.ServiceRepository.GetVacancy(VacancyId);
            string to = "hr1@amalco-agency.ru";
            if(vacancy.VacancyType==VacancyType.Nyanya)
            {
                to = "amalco929@yandex.ru";
            }
            if(vacancy.VacancyType==VacancyType.Para || vacancy.VacancyType == VacancyType.Voditel || vacancy.VacancyType == VacancyType.Povar || vacancy.VacancyType == VacancyType.Domrabotnica || vacancy.VacancyType ==VacancyType.Pomoshnik)
            {
                to = "hr7@amalco-agency.ru";
            }
            //if (vacancy.VacancyType == VacancyType.Povar)
            //{
            //    to = "amalco66@yandex.ru";
            //}
            var model = new VacancyResponseModel();
            model.Date = DateTime.UtcNow.AddHours(3);
            model.VacancyName = vacancy.Title;
            model.FamilyExperience = FamilyExperience;
            model.FullName = FullName;
            model.PhoneNumber = Number;
            model.HasCv = CVFile != null; 
            await _emailService.Send(
                await this.RenderViewToStringAsync("_VacancyResponse",model),
                $"Отклик на вакансию {vacancy.Title}",
                to,
                CVFile?.OpenReadStream(),
                CVFile?.FileName
                );
            TempData["FromResponse"] = true;
            return RedirectToAction("Applicants");
        }


    }
}