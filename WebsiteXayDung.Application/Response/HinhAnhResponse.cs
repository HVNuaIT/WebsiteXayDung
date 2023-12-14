using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteXayDung.Application.Interface;

namespace WebsiteXayDung.Application.Response
{
    public class HinhAnhResponse:IHinhAnh
    {
        private readonly string _userConten;
        private const string USER_CONTENT_FOLDER_NAME = "user-content";
        public HinhAnhResponse(IWebHostEnvironment webhostEnviroment)
        {
            _userConten = Path.Combine(webhostEnviroment.ContentRootPath, USER_CONTENT_FOLDER_NAME);
        }
        public async Task DeleteFile(string fileName)
        {
            var file = Path.Combine(_userConten, fileName);
            if (File.Exists(file))
            {
                await Task.Run(() => File.Delete(file));
            }
        }
        public string GetFile(string fileName)
        {
            return $"/{USER_CONTENT_FOLDER_NAME}/{fileName}";
        }
        public async Task SaveFile(Stream biye, string name)
        {
            var file = Path.Combine(_userConten, name);
            using var output = new FileStream(file, FileMode.Create);
            await biye.CopyToAsync(output);

        }
    }
}
