using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz*")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz*")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz*")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen mailinizi giriniz*")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifre giriniz*")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz*")]
        [Compare("Password",ErrorMessage ="Şifreler eşleşmedi*")]
        public string ConfirmPassword { get; set; }
    }
}
