using ImageService.BusinessLogic.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ImageService.BusinessLogic.Data
{
    public interface IApplicationContext
    {
        DbSet<ImageFile> ImageFiles { get; set; }
        DbSet<ImageTag> ImageTags { get; set; }
        Task<int> SaveChangesAsync();
    }
}
