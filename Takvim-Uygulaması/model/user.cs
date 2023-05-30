using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Takvim_Uygulaması.enumaration;

namespace Takvim_Uygulaması.model
{
    public class user
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string yetki { get; set; }
        public string tc { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public LoginStatus status { get; set; }
    }
}
