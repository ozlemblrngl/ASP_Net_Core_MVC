using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication_EFCoreWithMvcCore.Models.Entities
{
    [Table("Books")]
    public class Book
    {

        [Key] // Annotation diyor ama java için bu terim, c#'ta Attribute deniyor. Burada Key (primarykey) anahtar kolon olduğunu belirtiyor.
        public int Id { get; set; }
        
        [Display(Name = "Title"), Required(ErrorMessage = "Bu alan boş geçilemez"), StringLength(100, ErrorMessage = "En fazla 100 karakter olabilir")]  // string null alabilen yani zorunlu olmayan bir değerdir, dolu olması zorunlu olması için required yazmamız lazım.
        public string Title { get; set; }

        [Display(Name = "Summary"),StringLength(500,ErrorMessage = "En fazla 500 karakter olabilir")] // 
        public string Summary { get; set; }

        [Display(Name = "Author"),Required,StringLength(100, ErrorMessage = "En fazla 100 karakter olabilir")]
        public string Author { get; set; }
        // int null alamaz, 0'dır default değeri
        [Display(Name= "Page Count")]
        public int PageCount { get; set; }

        // bool da null alamaz false tur default değeri
        [Display(Name = "Published")]
        public bool Published {  get; set; } 



    }
}
