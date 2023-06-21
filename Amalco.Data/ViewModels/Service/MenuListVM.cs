using Amalco.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amalco.Data.ViewModels.Service
{
    public class MenuListVM
    {
        public ServiceType? ServiceType { get; set; }
        public string Title { get; set; }
        public List<ServiceListVM> ChildMenues{get;set;}
    }
}
