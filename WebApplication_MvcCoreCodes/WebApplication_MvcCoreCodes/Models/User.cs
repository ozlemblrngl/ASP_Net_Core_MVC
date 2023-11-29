using System.ComponentModel.DataAnnotations;

namespace WebApplication_MvcCoreCodes.Models
{
    public class User
    {
        [Required,ErrorMessage("Ad alanı zorunludur")]
        [StringLength(30),ErrorMessage("Ad alanı en fazla 30 karakter olabilir")]
        [Display(Name = "Ad")]
        public string FirstName{ get; set; }

        [Display(Name ="Soyad")]
        public string LastName { get; set; }

        [Display(Name ="Email Adres")]
        public string Email { get; set; }
    }
}
