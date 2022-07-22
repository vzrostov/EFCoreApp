using EFCoreApp.Core.Model;

namespace EFCoreApp.Core
{
    public interface IRepository
    {
        List<Post> GetPosts(Blog blog);
        void PutPost(Blog blog, Post post);
    }
}