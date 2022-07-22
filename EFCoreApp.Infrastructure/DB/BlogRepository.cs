using EFCoreApp.Core.Data;
using EFCoreApp.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApp.Infrastructure.DB
{
    internal class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(DbContext context) : base(context)
        {
        }
    }
}
