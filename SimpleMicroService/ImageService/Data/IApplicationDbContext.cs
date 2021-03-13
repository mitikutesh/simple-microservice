using ImageService.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ImageService.Data
{
    interface IApplicationDbContext
    {
        DbSet<ImageFile> ImageFiles { get; set; }
        DbSet<ImageTag> ImageTags { get; set; }
        DbSet<FileTag> FileTags { get; set; }
        Task<int> SaveChangesAsync();
    }
}
