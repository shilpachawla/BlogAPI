using BlogApplication.Services;
using BlogApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BlogApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private  readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        // GET: api/Blog
        [HttpGet]
        public IEnumerable<BlogDetailViewModel> Get()
        {
            return _blogService.GetAllBlog();
        }

        // GET: api/Blog/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Blog
        [HttpPost]
        public void Post([FromBody] BlogDetailViewModel blogDetailModel)
        {

            _blogService.AddBlog(blogDetailModel)  ;
        }

        // PUT: api/Blog/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] string content)
        {
            _blogService.UpdateBlog(id, content);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _blogService.RemoveBlog(id);
        }
    }
}
