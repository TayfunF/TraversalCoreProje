using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserRegisterVM
    {
        [Required(ErrorMessage = "Ad alanı zorunludur")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı zorunludur")]
        public string Username { get; set; }

        [Required(ErrorMessage = "E-posta alanı zorunludur")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar alanı zorunludur")]
        [Compare("Password", ErrorMessage = "Şifreler aynı değil")]
        public string ConfirmPassword { get; set; }
    }
}
