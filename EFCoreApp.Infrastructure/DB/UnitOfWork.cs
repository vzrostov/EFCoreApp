using EFCoreApp.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApp.Infrastructure.DB
{
    internal class UnitOfWork : IUnitOfWork
    {
        
        private readonly BloggingContext _context;
        private BlogRepository _blogRepository = null!;
        private PostRepository _postRepository = null!;

        public UnitOfWork(BloggingContext context)
        {
            this._context = context;
        }

        public IBlogRepository Blogs => _blogRepository = _blogRepository ?? new BlogRepository(_context);

        public IPostRepository Posts => _postRepository = _postRepository ?? new PostRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
