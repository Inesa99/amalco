using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Amalco.Data.Enums;
using Amalco.Data.Helpers;
namespace Amalco.Data.ViewModels.Service
{
    public class ServiceFullView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MainImage { get; set; }
        public string HeaderTitle { get; set; }
        public string Content { get; set; }
        public string MetaDescription { get; set; }
        public string PageTitle { get; set; }
        public string Responsibility { get; set; }
        public int? Price { get; set; }
        public string ResponsibilityTitle { get; set; }
        public string PriceTitle { get; set; }
        public ServicePayType? ServicePayType { get; set; }
        public List<string> ResponsibilityList => Responsibility != null ? Responsibility.Split('@').ToList() : new List<string>();
        public string DisplayPayType => ServicePayType.HasValue ? ServicePayType.DisplayName() : null;
        public bool IsPhilipin { get; set; }
    }
}
