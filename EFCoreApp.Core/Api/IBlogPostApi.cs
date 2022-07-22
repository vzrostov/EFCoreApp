using EFCoreApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApp.Core.Api
{
    public interface IBlogPostApi
    {
        Task<IEnumerable<Blog>> GetAllBlogsAsync(); // TODO replace to DTO
        Task<Blog> CreateBlogAsync(Blog blog);
        Task DeleteBlogAsync(Blog blog);
        //
        Task<IEnumerable<Post>> GetAllPostsAsync(int blogId);
        Task<Post> CreatePostAsync(Blog blog, Post post);
        Task DeletePostAsync(Post postId);
    }
}
