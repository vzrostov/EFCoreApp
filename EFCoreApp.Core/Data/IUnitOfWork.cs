using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApp.Core.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IBlogRepository Blogs { get; }
        IPostRepository Posts { get; }
        Task<int> CommitAsync();
    }
}
