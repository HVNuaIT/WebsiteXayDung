using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteXayDung.Application.Request;
using WebsiteXayDung.Application.Response;

namespace WebsiteXayDung.Application.Interface
{
    public interface IPost
    {
        List<PostRequest> AllList();
        public PostResponse AddPost(PostRequest postRequest);
        public void DeletePost(string postId);
        public string UpdatePost(string postId, PostResponse postResponse);
    }
}
