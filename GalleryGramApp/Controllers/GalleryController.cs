using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using GalleryGram.Models;
using System.Security.Claims;

namespace GalleryGram.Controllers
{
  public class GalleryController : Controller
  {
    private readonly GalleryGramContext _db;
    private IWebHostEnvironment _hostingEnvironment;
    private readonly UserManager<ApplicationUser> _userManager;
    public GalleryController(GalleryGramContext db, IWebHostEnvironment environment, UserManager<ApplicationUser> userManager)
    {
      _db = db;
      _hostingEnvironment = environment;
      _userManager = userManager;
    }
    
    [HttpGet("/gallery/upload")]
    public ActionResult Upload() {
      return View();
    }

    [HttpPost("/gallery/upload")]
    public async Task<IActionResult> GalleryUpload(IFormFile formFile)
    {
          string uploads = Path.Combine(_hostingEnvironment.WebRootPath, "pictures");
          Guid fileNameID = Guid.NewGuid();
          string fileExt =  System.IO.Path.GetExtension(formFile.FileName);
          List<string> validExts = new List<string>{".png", ".jpeg"};
          if (validExts.Contains(fileExt))
          {
            string fileName = fileNameID.ToString() + fileExt;
            string filePath = Path.Combine(uploads, fileName);
            using (Stream fileStream = new FileStream(filePath, FileMode.Create)) {
                await formFile.CopyToAsync(fileStream);
            }
            Picture newPicture = new Picture();
            newPicture.fileName = fileName;
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            newPicture.user_id = userId;
            _db.Pictures.Add(newPicture);
            _db.SaveChanges();
          }

        return Redirect("/");
    }
  }
}