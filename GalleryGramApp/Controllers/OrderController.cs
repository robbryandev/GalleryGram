using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using GalleryGram.Models;
using System.Security.Claims;
using GalleryGram.ResponseModels;

namespace GalleryGram.Controllers
{
  public class OrderController : Controller
  {
    private readonly GalleryGramContext _db;
    private IWebHostEnvironment _hostingEnvironment;
    private readonly UserManager<ApplicationUser> _userManager;
    public OrderController(GalleryGramContext db, IWebHostEnvironment environment, UserManager<ApplicationUser> userManager)
    {
      _db = db;
      _hostingEnvironment = environment;
      _userManager = userManager;
    }
    
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(string line1, string line2, string postalOrZipCode, string countryCode, string townOrCity, string stateOrCounty)
    {
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      // User name is currently the email
      string userName = HttpContext.User.Identity.Name;
      string userEmail = userName;
      GalleryGram.Models.Address newAddress = new GalleryGram.Models.Address();
      newAddress.line1 = line1;
      newAddress.line2 = line2;
      newAddress.postalOrZipCode = postalOrZipCode;
      newAddress.countryCode = countryCode;
      newAddress.townOrCity = townOrCity;
      newAddress.stateOrCounty = stateOrCounty;

      OrderResponse response = await OrderRequest.Post(newAddress, userName, userEmail);

      DbOrder newOrder = new DbOrder();
      newOrder.user_id = userId;
      newOrder.confirmation_id = response.order.id;
      newOrder.status = response.order.status.stage;
      newOrder.cost = "9.99"; //response.order.items[0].recipientCost.amount is null for some reason;

      _db.DbOrders.Add(newOrder);
      _db.SaveChanges();

      return Redirect($"/order/confirm/{newOrder.confirmation_id}"); 
    }

    [HttpGet("/order/confirm/{confirmation_id}")]
    public ActionResult Confirm(string confirmation_id)
    {
      DbOrder order = _db.DbOrders
        .FirstOrDefault(entry => entry.confirmation_id == confirmation_id);

      return View(order);
    }
  }
}