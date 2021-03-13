using ImageService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageService.Data
{
    public class ApplicationContext : DbContext, IApplicationDbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }
        public DbSet<FileTag> FileTags { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
