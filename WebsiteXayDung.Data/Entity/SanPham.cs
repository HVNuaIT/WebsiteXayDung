using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteXayDung.Data.Enum;

namespace WebsiteXayDung.Data.Entity
{
   public class SanPham
    {
       public int Id {  get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; } = string.Empty;
        public Status Status { get; set; }
        public int IdDanhMuc {  get; set; }
        public DanhMuc ?DanhMuc { get; set; }
        public List<HinhAnh> HinhAnh { get; set; }
    }
}
