using Patterns.Data;
using Patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private ApplicationDbContext _db;
        public BlogRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Blog> GetBlogs()
        {
            var blogs = _db.Blogs.ToList();
            return blogs;
        }
    }
}
