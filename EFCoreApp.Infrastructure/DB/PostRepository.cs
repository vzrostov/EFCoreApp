using EFCoreApp.Core.Data;
using EFCoreApp.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApp.Infrastructure.DB
{
    internal class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(DbContext context) : base(context)
        {
        }

        public List<Post> GetPosts(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void PutPost(Blog blog, Post post)
        {
            throw new NotImplementedException();
        }
    }
}
