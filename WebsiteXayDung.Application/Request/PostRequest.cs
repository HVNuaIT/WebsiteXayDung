using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteXayDung.Data.Entity;
using WebsiteXayDung.Data.Enum;

namespace WebsiteXayDung.Application.Request
{
    public class PostRequest
    {
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; } = string.Empty;
        public Status Status { get; set; }
        public int IdDanhMuc { get; set; }
        public List<HinhAnh> HinhAnh { get; set; }
    }
}
