using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApplication.Models;
using BlogApplication.ViewModel;

namespace BlogApplication.Services
{
    public interface IBlogService
    {
         void AddBlog(BlogDetailViewModel blogDetail);

         bool UpdateBlog(Guid id, string content);

         bool RemoveBlog(Guid id);

         IEnumerable<BlogDetailViewModel> GetAllBlog();

    }
}
