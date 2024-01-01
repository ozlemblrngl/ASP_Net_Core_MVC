using System.ComponentModel.DataAnnotations;

namespace WebApplication_FirstAspNetCoreApp.Models
{
    // Data Annotation
    public class Customer
    {
        [Required, MaxLength(30)] // required demezsek string'in default değeri null olduğundan null geçilebilir. O nedenle string de null geçilmesini istemiyorsak required demeliyiz.
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Range(0, 130)] // required demeyiz çünkü default değeri int'in 0'dır. o nedenle her türlü bir sayısal değeri vardır. Sayı aralığı belirtebiliriz.
        public int Age { get; set; }

        [CreditCard] // kredi kartı sayı kontrolu yapan attribute'tur.
        public string CreditCardNumber { get; set; }

        [Phone] // telefon numarası kontrolu yapan attribute'tür
        public string Phone { get; set; }

        [Url] // url kontrolu yapar. 
        public string LinkednUrl { get; set; }

        [EmailAddress, MaxLength(50)] // mail adresi kontrolu yapar.İstersek en uzun değerini de belirtebiliriz.
        public string Email { get; set; }

        [StringLength(250, MinimumLength = 30)] // adresin mak uzunluğu 250, min uzunluğu 30 dur.
        public string Address { get; set; }

        [RegularExpression("[a-z]{3}-[0-9]{2}-[5-9]{4}")] // bu şekilde özel bir şart tanıyabiliriz.(regex)
        public string PostalCode { get; set; }

        [Required, StringLength(24, MinimumLength = 8), Compare(nameof(RePassword))] // zorunlu, max 24 min 8 karakterli ve ikinci kez girilen şifreyle karşılaştırmalı
        public string Password { get; set; }  // Compare("RePassword") de yazabiliriz ancak o zaman RePassword'un ismi değişirse hata almayız bu kodda. nameof ile yaparsak ikinci şifrenin adı değiştiğinde bize doğrusunu yapmak üzere uyarı verir.3

        [Required, StringLength(24, MinimumLength = 8)]
        public string RePassword { get; set; }

    }
}
