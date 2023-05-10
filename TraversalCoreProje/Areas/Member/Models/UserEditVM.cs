using Microsoft.AspNetCore.Http;

namespace TraversalCoreProje.Areas.Member.Models
{
    public class UserEditVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
    }
}
