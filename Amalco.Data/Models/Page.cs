using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace Amalco.Data.Models
{
    public class Page:Seo
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public string Content { get; set; }
        public string Content2 { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifedDate { get; set; }
        public int? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual Page Parent { get; set; }

        public virtual ICollection<Page> ChildPages { get; set; }
    }
}
