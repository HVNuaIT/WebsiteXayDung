using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteXayDung.Application.Request
{
    public class LoginRequest
    {
        [Required(ErrorMessage ="Xin Vui Lòng Nhập Tài Khoản")]
        [Display(Name ="Tài Khoản")]
        public string UserName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Xin Vui Lòng Nhập Mật Khẩu")]
        [Display(Name = "Mật Khẩu")]
        public string Password { get; set; } = string.Empty;
    }
}
