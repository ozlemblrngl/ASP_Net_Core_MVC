using System.ComponentModel.DataAnnotations;

namespace WebApplication_MvcCoreCodes.Models
{
    public class User
    {
        [Required(ErrorMessage="Ad alanı zorunludur")]
        [StringLength(30, ErrorMessage = "Ad alanı en fazla 30 karakter olabilir")]
        [Display(Name = "Ad")]
        public string FirstName{ get; set; }

        [Required(ErrorMessage="Soyad alanı zorunludur")]
        [StringLength(30, ErrorMessage="Soyad alanı en fazla 30 karakter olabilir")]
        [Display(Name ="Soyad")]
        public string LastName { get; set; }

        [Required(ErrorMessage="Mail alanı zorunludur")]
        [StringLength(50,ErrorMessage= "Mail alanı en fazla 50 karakter olabilir")]
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir mail adresi giriniz")] 
        [Display(Name ="Email Adres")]
        public string Email { get; set; }
    }
}
