using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteXayDung.Data.Entity
{
    public class DanhMuc
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public  List<SanPham>? SanPham { get; set; }
    }
}
