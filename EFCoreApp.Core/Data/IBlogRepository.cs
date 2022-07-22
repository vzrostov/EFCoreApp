using EFCoreApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApp.Core.Data
{
    public interface IBlogRepository : IRepository<Blog>
    {
    }
}
