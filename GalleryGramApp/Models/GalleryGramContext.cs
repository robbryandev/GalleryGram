using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace GalleryGram.Models 
{
  public class GalleryGramContext : IdentityDbContext<ApplicationUser>
  {
    // public DbSet<ClassName> ClassNames { get; set; }   CHANGE CLASS NAME!!!

    public GalleryGramContext(DbContextOptions options) : base(options) { } 
  }
}
