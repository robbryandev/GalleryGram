using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace GalleryGram.Models 
{
  public class GalleryGramContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Picture> Pictures { get; set; }

    public GalleryGramContext(DbContextOptions options) : base(options) { } 
  }
}
