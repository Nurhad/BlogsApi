using BlogsApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogsApi.Interfaces
{
    public interface IBlogService
    {
        Task<List<Blog>> GetAllBlogs();
        Task<List<Blog>> GetBlogsUnderCategory(int id);
    }
}
