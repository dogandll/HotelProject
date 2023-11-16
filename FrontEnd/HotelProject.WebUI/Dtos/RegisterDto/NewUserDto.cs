using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class NewUserDto
    {
        [Required(ErrorMessage = "Ad alanı zorunludur !")]
        public string Name { get; set; }
        [Required(ErrorMessage = "SoyAd alanı zorunludur !")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "KullanıcıAdı alanı zorunludur !")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mail alanı zorunludur !")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre alanı zorunludur !")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrar alanı zorunludur !")]
        [Compare("Password", ErrorMessage = "Şifreler birbirleri ile uyuşmamaktadır !")]
        public string ConfirmPassword { get; set; }
    }
}
