using Amalco.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amalco.Data.ViewModels.Service
{
    public class ServiceAddEdit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MetaDescription { get; set; }
        public string PageTile { get; set; }
        public string MainImage { get; set; }
        public int? Price { get; set; }
        public string Content { get; set; }
        public string ResponsibilityTitle { get; set; }
        public string PriceTitle { get; set; }
        public string Url { get; set; }
        public string OrderBannerImage { get; set; }
        public ServicePayType? ServicePayType { get; set; }
        public ServiceType ServiceType { get; set; }
        public string HeaderText { get; set; }
        public string Responsibility { get; set; }

        public List<string> ResponsibilityList => Responsibility!=null? Responsibility.Split('@').ToList():new List<string>();
        public List<string> ResponsibilityStrings { get; set; }
    }
}
