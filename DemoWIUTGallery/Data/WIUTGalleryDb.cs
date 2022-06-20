using DemoWIUTGallery.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoWIUTGallery.Data
{
    public class WIUTGalleryDb: DbContext
    {
        public DbSet<Photo> WIUTGallery { get; set; }
        public WIUTGalleryDb(DbContextOptions<WIUTGalleryDb> options)
            : base(options) { }
    }
}
