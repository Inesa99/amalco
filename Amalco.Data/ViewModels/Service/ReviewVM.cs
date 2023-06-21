using System;
using System.Collections.Generic;
using System.Text;

namespace Amalco.Data.ViewModels.Service
{
    public class ReviewVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime Created { get; set; }
    }
}
