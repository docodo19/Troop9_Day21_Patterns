using System.Collections.Generic;
using Patterns.Models;

namespace Patterns.Repositories
{
    public interface IBlogRepository
    {
        List<Blog> GetBlogs();
    }
}