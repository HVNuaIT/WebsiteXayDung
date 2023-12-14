using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteXayDung.Data.Enum;

namespace WebsiteXayDung.Data.Entity
{
    public class ThongTinDoanhNghiep
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Status Status { get; set; }
        public int IdHinhAnh { get; set; }
        public HinhAnh Images {  get; set; }

    }
}
