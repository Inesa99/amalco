using System;
using System.Collections.Generic;
using System.Text;

namespace Amalco.Data.ViewModels.Page
{
   public class PageViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Content2 { get; set; }
        public string Name { get; set; }
        public string MetaDescription { get; set; }
        public string PageTitle { get; set; }
        public string Url { get; set; }
        public List<ChildPage> ChildPages { get; set; }
    }

    public class ChildPage
    {
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
