using System;
using System.Collections.Generic;
using System.Text;

namespace Amalco.Data.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
