using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;

namespace Amalco.Data.ViewModels.Order
{
    public class CrmModel
    {
        public string roistat { get; set; }
        public string key { get; set; }
        public string title { get; set; }
        public string comment { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
       public string pipeline { get; set; }

        public CrmModel()
        {
            key = "MjExMTE3OjEyNjAwMDo3YTg5MzFmMjVhODlkZjNhNTA0ZGFlZDk4Y2U2MzkyMw==";
            
        }

    }

    
    
   
}
