using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogTracker;

namespace BlogTracker.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext (DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlogTracker.AdminInfo> AdminInfo { get; set; } = default!;

        public DbSet<BlogTracker.BlogInfo>? BlogInfo { get; set; }

        public DbSet<BlogTracker.EmpInfo>? EmpInfo { get; set; }
    }
}
