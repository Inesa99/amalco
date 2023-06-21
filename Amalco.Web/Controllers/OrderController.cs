using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amalco.Data.Repositories.Interfaces;
using Amalco.Data.ViewModels.Order;
using Amalco.Web.Service;
using Amalco.Web.Extentions;
using System.Net.Http;
using Amalco.Data.Enums;
using Amalco.Data.Models;
using Amalco.Data;

namespace Amalco.Web.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IEmailService _emailService;
        private readonly Context _context;
        public OrderController(IUnitofWork uow,IEmailService emailService, Context context):base(uow)
        {
            _emailService = emailService;
            _context = context;
        }
        public async Task< IActionResult> Index()
        {
            ViewBag.services = await Uow.ServiceRepository.AdminServiceList();
            var model = await Uow.PageRepository.GetByIdOrUrl(url: "zakazat-domashniy-personal");
            return View(model);
            
        }

        [HttpGet]
        public IActionResult Call()
        {
            
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> Call(CallOderModel model)
        {
            Order order = new Order
            {
                Date = DateTime.UtcNow.AddHours(3),
                Comment = model.Comment,
                PhoneNumber = model.PhoneNumber,
                FullName = model.Name,
              
                OrderType = OrderType.Call,

            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            var crmcookie = Request.Cookies["roistat_visit"];
            var text = await this.RenderViewToStringAsync<CallOderModel>("_OrderCall", model);
            await _emailService.Send(text, "Заявка на обратный звонок");
          

           

            return Json(new { success = true });
        }
        [HttpPost]
        public async Task<JsonResult> Add(OrderAddViewModel model)
        {
            
            if(model.ServiceId.HasValue)
            {
                model.ServiceName = await Uow.ServiceRepository.ServiceNameById(model.ServiceId.Value);
            }
          
            await _emailService.Send(model);
            return Json(new {success=true });
        }
    }
}