using System;
using System.Collections.Generic;
using System.Text;

namespace Amalco.Data.ViewModels.Profile
{
   public class ProfileViewModel
    {
        private string _expirence;
        public int Id { get; set; }
        public string FirstNae { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public string Expirence
        {
            get
            {
                return _expirence!=null&&_expirence.Length>150?$"{_expirence.Remove(150)}...":_expirence;
            }
            set
            {
                _expirence = value;
            }
        }
    }
}
