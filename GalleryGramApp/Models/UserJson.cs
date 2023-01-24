using Microsoft.AspNetCore.Identity;

namespace GalleryGram.Models 
{
    public class Address
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public Geo geo { get; set; }
    }

    public class Company
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
    }

    public class Geo
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }

    public class UserJson
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }
        public ApplicationUser toUser()
        {
            ApplicationUser newUser = new ApplicationUser();
            newUser.Email = email;
            newUser.UserName =name;
            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();  
            passwordHasher.HashPassword(newUser, "password");  
            return newUser;
        }
    }
}