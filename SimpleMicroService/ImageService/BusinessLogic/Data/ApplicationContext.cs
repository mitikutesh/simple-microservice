using ImageService.BusinessLogic.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ImageService.BusinessLogic.Data
{
    public class ApplicationContext : DbContext, IApplicationDbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
