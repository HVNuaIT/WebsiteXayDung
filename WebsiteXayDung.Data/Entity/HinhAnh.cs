using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteXayDung.Data.Entity
{
    public class HinhAnh
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; } = string.Empty;
        public int IdSanPham {  get; set; } 
        public SanPham SanPham { get;set; }
   


    }
}
