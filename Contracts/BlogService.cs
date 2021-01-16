using BlogApplication.Models;
using BlogApplication.Services;
using BlogApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace BlogApplication.Contracts
{
    public class BlogService : IBlogService
    {
        private readonly IMapper _mapper;
        public BlogService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public void AddBlog(BlogDetailViewModel blogDetailViewModel)
        {
            try
            {
                var blogDetail = _mapper.Map<BlogDetail>(blogDetailViewModel);
                using (BlogDBContext blogDbContext = new BlogDBContext())
                {
                    blogDbContext.Add(blogDetail);
                    blogDbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IEnumerable<BlogDetailViewModel> GetAllBlog()
        {
            try
            {
                List<BlogDetail> blogDetails;
                using (BlogDBContext blogDbContext = new BlogDBContext())
                {
                    blogDetails = blogDbContext.BlogDetails.ToList();
                }
                var blogDetailViewModel = _mapper.Map<List<BlogDetailViewModel>>(blogDetails);
                return blogDetailViewModel;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool RemoveBlog(Guid id)
        {
            try
            {
                int isDeleted = 0;
                using (BlogDBContext blogDbContext = new BlogDBContext())
                {
                    var blogDetails = blogDbContext.BlogDetails.FirstOrDefault(t => t.BlogId == id);
                    if (blogDetails != null)
                    {
                        blogDbContext.Entry(blogDetails).State = EntityState.Deleted;
                        isDeleted = blogDbContext.SaveChanges();
                    }
                
                }

                return isDeleted > 0 ? true : false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool UpdateBlog(Guid id, string content)
        {
            try
            {
                int isSaved =0 ;
                using (BlogDBContext blogDbContext = new BlogDBContext())
                {
                    var blogDetails = blogDbContext.BlogDetails?.FirstOrDefault(t => t.BlogId == id);
                    if(blogDetails != null)
                    {
                        blogDetails.BlogContent = content;
                    }
                    isSaved = blogDbContext.SaveChanges();
                }

                return isSaved > 0 ? true : false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
