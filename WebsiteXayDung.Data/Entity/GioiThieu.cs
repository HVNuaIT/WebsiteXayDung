using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteXayDung.Data.Enum;

namespace WebsiteXayDung.Data.Entity
{
    public class GioiThieu
    {
        public int Id {  get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }

    }
}
