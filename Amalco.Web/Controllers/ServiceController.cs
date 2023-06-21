using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amalco.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Amalco.Data.Repositories;
using Amalco.Data.ViewModels.Profile;
using Amalco.Data;
using Microsoft.EntityFrameworkCore;

namespace Amalco.Web.Controllers
{
    public class ServiceController : BaseController
    {
        private ProfileContext _profileContext;
        public ServiceController(IUnitofWork uow,ProfileContext context):base(uow)
        {
            _profileContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await Uow.PageRepository.GetByIdOrUrl(url: "uslugi");
            ViewBag.services = await Uow.ServiceRepository.AdminServiceList();
            return View(model);
        }
        //[HttpGet("{url}/{subUrl?}")]
        public async Task<IActionResult> Page(string url,string subUrl)
        {
            
            var model = await Uow.ServiceRepository.FullView(url);
            if(model==null)
            {
                var content = subUrl==null? await Uow.PageRepository.GetByIdOrUrl(url: url):await Uow.PageRepository.GetByIdOrUrl(url:subUrl,subUrl:url);
               if(content==null)
                {
                    Response.StatusCode = 404;
                    return View("Error");
                }
                return View("Article",content);
            }
            #region Profiles
            switch(url)
            {
                case "domrabotnica":
                case "gornichnaya":
                ViewBag.profiles = await _profileContext.Domrabotnicas.Where(p=>p.ShowInWebSite)
                        .OrderBy(m=>Guid.NewGuid())
                .Select(n => new ProfileViewModel
                {
                    Id=n.ID,
                    FirstNae=n.FirstName,
                    Text=n.About,
                    Image=n.Image,
                    Expirence=n.FamilyExperience
                }).Take(4).ToListAsync();
                    ViewBag.url = "domrabotnica";
                    break;
                case "personalnyj-voditel":
                    ViewBag.profiles = await _profileContext.Voditels.Where(p => p.ShowInWebSite)
                         .OrderBy(m => Guid.NewGuid())
               .Select(n => new ProfileViewModel
               {
                   Id = n.ID,
                   FirstNae = n.FirstName,
                   Text = n.About,
                   Image = n.Image,
                   Expirence = n.FamilyExperience
               }).Take(4).ToListAsync();
                    ViewBag.url = "voditel";
                    break;
                case "sidelka":
                    ViewBag.profiles = await _profileContext.Sidelkas.Where(p => p.ShowInWebSite)
                         .OrderBy(m => Guid.NewGuid())
               .Select(n => new ProfileViewModel
               {
                   Id = n.ID,
                   FirstNae = n.FirstName,
                   Text = n.About,
                   Image = n.Image,
                   Expirence = n.FamilyExperience
               }).Take(4).ToListAsync();
                    ViewBag.url = "sidelka";
                    break;
                case "povar":
                    ViewBag.profiles = await _profileContext.Povars.Where(p => p.ShowInWebSite)
                         .OrderBy(m => Guid.NewGuid())
               .Select(n => new ProfileViewModel
               {
                   Id = n.ID,
                   FirstNae = n.FirstName,
                   Text = n.About,
                   Image = n.Image,
                   Expirence = n.FamilyExperience
               }).Take(4).ToListAsync();
                    ViewBag.url = "povar";
                    break;
                case "semejnaya-para":
                    ViewBag.profiles = await _profileContext.Semeynaya_Para.Where(p => p.ShowInWebSite)
                         .OrderBy(m => Guid.NewGuid())
               .Select(n => new ProfileViewModel
               {
                   Id = n.ID,
                   FirstNae = n.FirstName,
                   Text = n.About,
                   Image = n.Image,
                   Expirence = n.FamilyExperience
               }).Take(4).ToListAsync();
                    ViewBag.url = "para";
                    break;
                case "nyanya-vospitatel":
                    ViewBag.profiles = await _profileContext.Nyanyas.Where(p => p.ShowInWebSite&&!p.age_category.Contains("4"))
                         .OrderBy(m => Guid.NewGuid())
               .Select(n => new ProfileViewModel
               {
                   Id = n.ID,
                   FirstNae = n.FirstName,
                   Text = n.About,
                   Image = n.Image,
                   Expirence = n.FamilyExperience
               }).Take(4).ToListAsync();
                    ViewBag.url = "nyanya";
                    break;
                case "nyanya-grudnichku":
                    ViewBag.profiles = await _profileContext.Nyanyas.Where(p => p.ShowInWebSite && p.age_category.Contains("4"))
                         .OrderBy(m => Guid.NewGuid())
               .Select(n => new ProfileViewModel
               {
                   Id = n.ID,
                   FirstNae = n.FirstName,
                   Text = n.About,
                   Image = n.Image,
                   Expirence = n.FamilyExperience
               }).Take(4).ToListAsync();
                    ViewBag.url = "nyanya";
                    break;

                case "nyanya-filippinka":
                    ViewBag.profiles = await _profileContext.ForeignStaffs.Where(p => p.ShowInWebSite && p.type=="n")
                         .OrderBy(m => Guid.NewGuid())
               .Select(n => new ProfileViewModel
               {
                   Id = n.ID,
                   FirstNae = n.FirstName,
                   Text = n.About,
                   Image = n.Image,
                   Expirence = n.FamilyExperience
               }).Take(4).ToListAsync();
                    ViewBag.url = "foreign";
                    break;
                case "domrabotnica-filippinka":
                    ViewBag.profiles = await _profileContext.ForeignStaffs.Where(p => p.ShowInWebSite && p.type == "d")
                         .OrderBy(m => Guid.NewGuid())
               .Select(n => new ProfileViewModel
               {
                   Id = n.ID,
                   FirstNae = n.FirstName,
                   Text = n.About,
                   Image = n.Image,
                   Expirence = n.FamilyExperience
               }).Take(4).ToListAsync();
                    ViewBag.url = "foreign";
                    break;
                default:
                    ViewBag.profiles = new List<ProfileViewModel>(); 
                    break;

            }
   
            #endregion
            if(model.IsPhilipin)
            {
                var services = await Uow.ServiceRepository.AdminServiceList();
                ViewBag.services =services.Where(s=> s.Id == 16 || s.Id == 17 || s.Id == 19 || s.Id == 20) ;
                return View("Philipins", model);
            }
            
                return View(model);
        }
        public IActionResult Philipins()
        {
            return View();
        }
    }
}