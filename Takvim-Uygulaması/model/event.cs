using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takvim_Uygulaması.model
{
    public class events
    {
        public int id { get; set; }
        public string username { get; set; }
        public string olay { get; set;}
        public  DateTime tarih { get; set; }
        public DateTime alarm{ get; set; }



    }
}
