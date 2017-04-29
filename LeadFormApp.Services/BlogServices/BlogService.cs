using System.Collections.Generic;
using LeadFormApp.Domain.Entities;
using LeadFormApp.Domain.Interfaces;

namespace LeadFormApp.Services.BlogServices
{
    public class BlogService : IBlogService
    {
        private readonly IRepository<Blog> _blogRepository;

        public BlogService(IRepository<Blog> blogRepository)
        {
            this._blogRepository = blogRepository;            
        }

        public void AddBlog(Blog blog)
        {
            _blogRepository.Insert(blog);
        }
        
        public IEnumerable<Blog> GetBlogs()
        {
            return _blogRepository.GetAllNoTracking;
        }
        
        public Blog Find(int id)
        {
            return _blogRepository.GetById(id);
        }

        public void Insert(Blog model)
        {
            _blogRepository.Insert(model);
        }
    }
}