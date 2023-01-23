using Microsoft.AspNetCore.Mvc;
using GalleryGram.Models;

namespace GalleryGram.Controllers
{
  public class GalleryController : Controller
  {
    private readonly GalleryGramContext _db;
    private IWebHostEnvironment _hostingEnvironment;
    public GalleryController(GalleryGramContext db, IWebHostEnvironment environment)
    {
      _db = db;
      _hostingEnvironment = environment;
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
          }

        return Redirect("/");
    }
  }
}