using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteXayDung.Application.Interface;
using WebsiteXayDung.Application.Request;
using WebsiteXayDung.Data.EF;

namespace WebsiteXayDung.Application.Response
{
    public class PostResponse : IPost
    {
        public readonly XayDungDb _db;

        public PostResponse(XayDungDb db) {
                _db=db;
        }
        public PostResponse AddPost(PostRequest postRequest)
        {
            throw new NotImplementedException();
        }

        public List<PostRequest> AllList()
        {
            var list = _db.SanPhams.ToList();
            var hienThi = list.Select(x => new PostRequest
            {
                Date = x.Date,
                Description = x.Description,
                HinhAnh = x.HinhAnh,
                IdDanhMuc= x.IdDanhMuc,
                Name = x.Name,
                Status = x.Status
            });
            return hienThi.ToList();
        }

        public void DeletePost(string postId)
        {
            var check = _db.SanPhams.Where(x => x.Id == Convert.ToInt32(postId)).FirstOrDefault();
            if (check != null)
            {
                _db.SanPhams.Remove(check);
                _db.SaveChanges();
            }
        }

        public string UpdatePost(string postId, PostResponse postResponse)
        {
            throw new NotImplementedException();
        }
    }
}
