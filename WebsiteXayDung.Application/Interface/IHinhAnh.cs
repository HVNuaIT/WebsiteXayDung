using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteXayDung.Application.Interface
{
    public interface IHinhAnh
    {
        string GetFile(string fileName);
        Task SaveFile(Stream biye, string name);
        Task DeleteFile(string fileName);
    }
}
